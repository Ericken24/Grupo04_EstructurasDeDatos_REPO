using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>Una conexión entre dos sucursales, con su costo y si tiene conectividad.</summary>
    public class Arista
    {
        public string Origen;
        public string Destino;
        public decimal Costo;
        public bool Disponible;

        public Arista(string origen, string destino, decimal costo, bool disponible)
        {
            Origen = origen;
            Destino = destino;
            Costo = costo;
            Disponible = disponible;
        }
    }

    /// <summary>Una sucursal del grafo con la lista de sus vecinas (lista de adyacencia).</summary>
    public class NodoGrafo
    {
        public string Codigo;
        public ListaSimple<Arista> Vecinos = new ListaSimple<Arista>();

        public NodoGrafo(string codigo)
        {
            Codigo = codigo;
        }
    }

    /// <summary>
    /// Grafo no dirigido y con pesos de las sucursales (simulación de la red de sincronización).
    /// - Se guarda como lista de adyacencia: cada sucursal tiene su lista de vecinas.
    /// - Para los algoritmos se arma la matriz de adyacencia (tabla de costos directos).
    /// - Floyd-Warshall calcula la ruta más barata entre cualquier par de sucursales.
    /// - Prim calcula la red que conecta a todas las sucursales con el menor costo total.
    /// Solo cuentan los enlaces con conectividad (Disponible = true).
    /// </summary>
    public class GrafoSucursales
    {
        /// <summary>Costo que representa "no hay camino".</summary>
        public const decimal Infinito = 1000000m;

        private readonly ListaSimple<NodoGrafo> nodos = new ListaSimple<NodoGrafo>();
        private string[] codigos = new string[0];                                   // código de cada fila/columna de las matrices
        private decimal[,] adyacencia = new decimal[0, 0];                          // costo directo entre dos sucursales
        private decimal[,] distancia = new decimal[0, 0];                           // resultado de Floyd-Warshall
        private int[,] siguiente = new int[0, 0];                                   // para reconstruir la ruta

        public int CantidadNodos => nodos.Cantidad;

        // Armar el grafo: agregar sucursales y enlaces (con costo y disponibilidad)
        /// <summary>Arma el grafo con los enlaces guardados en enlaces_sync.json.</summary>
        public static GrafoSucursales Desde(IEnumerable<EnlaceSync> enlaces)
        {
            GrafoSucursales grafo = new GrafoSucursales();
            foreach (EnlaceSync enlace in enlaces)
                grafo.AgregarArista(enlace.Origen, enlace.Destino, enlace.Costo, enlace.Disponible);
            return grafo;
        }

        public void AgregarNodo(string codigo)
        {
            if (BuscarNodo(codigo) == null) nodos.AgregarFinal(new NodoGrafo(codigo));
        }

        /// <summary>Une dos sucursales (en ambos sentidos). Si alguna no existe, la crea.</summary>
        public void AgregarArista(string origen, string destino, decimal costo, bool disponible)
        {
            AgregarNodo(origen);
            AgregarNodo(destino);
            BuscarNodo(origen)!.Vecinos.AgregarFinal(new Arista(origen, destino, costo, disponible));
            BuscarNodo(destino)!.Vecinos.AgregarFinal(new Arista(destino, origen, costo, disponible));
        }

        private NodoGrafo? BuscarNodo(string codigo)
        {
            foreach (NodoGrafo nodo in nodos)
            {
                if (nodo.Codigo == codigo) return nodo;
            }
            return null;
        }

        private int PosicionDe(string codigo)
        {
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == codigo) return i;
            }
            return -1;
        }

        /// <summary>Convierte la lista de adyacencia en la matriz de adyacencia (solo enlaces disponibles).</summary>
        private void ArmarMatrizAdyacencia()
        {
            int n = nodos.Cantidad;
            codigos = new string[n];
            adyacencia = new decimal[n, n];

            int posicion = 0;
            foreach (NodoGrafo nodo in nodos)
            {
                codigos[posicion] = nodo.Codigo;
                posicion++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) adyacencia[i, j] = 0;
                    else adyacencia[i, j] = Infinito;
                }
            }

            foreach (NodoGrafo nodo in nodos)
            {
                int fila = PosicionDe(nodo.Codigo);
                foreach (Arista arista in nodo.Vecinos)
                {
                    if (!arista.Disponible) continue;                               // enlace caído: no se puede usar
                    int columna = PosicionDe(arista.Destino);
                    if (arista.Costo < adyacencia[fila, columna]) adyacencia[fila, columna] = arista.Costo;
                }
            }
        }

        // Floyd-Warshall: ruta más barata entre cualquier par de sucursales, en este orden: origen -> intermedia -> destino
        /// <summary>
        /// Calcula el costo mínimo entre todas las parejas de sucursales.
        /// Idea: probar si pasar por una sucursal intermedia (k) sale más barato que ir directo.
        /// </summary>
        public void CalcularFloydWarshall()
        {
            ArmarMatrizAdyacencia();
            int n = codigos.Length;
            distancia = new decimal[n, n];
            siguiente = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distancia[i, j] = adyacencia[i, j];
                    if (i != j && adyacencia[i, j] < Infinito) siguiente[i, j] = j;
                    else siguiente[i, j] = -1;
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (distancia[i, k] + distancia[k, j] < distancia[i, j])
                        {
                            distancia[i, j] = distancia[i, k] + distancia[k, j];
                            siguiente[i, j] = siguiente[i, k];
                        }
                    }
                }
            }
        }

        /// <summary>Costo de la ruta más barata (Infinito si no hay ruta). Primero llamar a CalcularFloydWarshall.</summary>
        public decimal CostoRuta(string origen, string destino)
        {
            int i = PosicionDe(origen);
            int j = PosicionDe(destino);
            if (i < 0 || j < 0) return Infinito;
            return distancia[i, j];
        }

        /// <summary>Sucursales por las que pasa la ruta más barata, de origen a destino (vacía si no hay ruta).</summary>
        public ListaSimple<string> ObtenerRuta(string origen, string destino)
        {
            ListaSimple<string> ruta = new ListaSimple<string>();
            int i = PosicionDe(origen);
            int j = PosicionDe(destino);
            if (i < 0 || j < 0) return ruta;
            if (distancia[i, j] >= Infinito) return ruta;                           // sin ruta

            ruta.AgregarFinal(codigos[i]);
            while (i != j)
            {
                i = siguiente[i, j];
                ruta.AgregarFinal(codigos[i]);
            }
            return ruta;
        }

        // Prim: red de menor costo que conecta todas las sucursales alcanzables desde un inicio, en este orden: origen -> destino
        /// <summary>
        /// Red de menor costo que conecta las sucursales alcanzables desde "inicio".
        /// Idea: se empieza en una sucursal y en cada paso se agrega el enlace más barato
        /// que lleva a una sucursal que todavía no está conectada.
        /// </summary>
        public ListaSimple<Arista> CalcularPrim(string inicio)
        {
            ArmarMatrizAdyacencia();
            ListaSimple<Arista> red = new ListaSimple<Arista>();

            int n = codigos.Length;
            int posicionInicio = PosicionDe(inicio);
            if (posicionInicio < 0) return red;

            bool[] conectada = new bool[n];
            conectada[posicionInicio] = true;

            for (int paso = 1; paso < n; paso++)
            {
                decimal mejorCosto = Infinito;
                int mejorOrigen = -1;
                int mejorDestino = -1;

                for (int i = 0; i < n; i++)
                {
                    if (!conectada[i]) continue;
                    for (int j = 0; j < n; j++)
                    {
                        if (conectada[j]) continue;
                        if (adyacencia[i, j] < mejorCosto)
                        {
                            mejorCosto = adyacencia[i, j];
                            mejorOrigen = i;
                            mejorDestino = j;
                        }
                    }
                }

                if (mejorOrigen == -1) break;                                       // las demás sucursales no se pueden alcanzar

                conectada[mejorDestino] = true;
                red.AgregarFinal(new Arista(codigos[mejorOrigen], codigos[mejorDestino], mejorCosto, true));
            }
            return red;
        }
    }
}
