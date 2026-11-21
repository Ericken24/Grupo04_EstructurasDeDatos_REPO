namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Árbol binario de búsqueda (ABB) con claves de texto.
    /// Regla: lo menor va a la izquierda y lo mayor a la derecha, así que para buscar
    /// se descarta la mitad del camino en cada paso (como buscar una palabra en un diccionario).
    /// Todas las operaciones son recursivas.
    /// </summary>
    public class ArbolBinarioBusqueda<T>
    {
        private NodoArbol<T>? raiz;
        private bool seElimino;               // avisa si Eliminar encontró la clave

        /// <summary>Cantidad de claves distintas guardadas.</summary>
        public int Cantidad { get; private set; }

        public bool EstaVacio => raiz == null;
        // insertar (cualquier nodo diferente o repetido) -> si la clave ya existe, se guarda el dato en el mismo nodo (lista de datos)
        public void Insertar(string clave, T dato)
        {
            raiz = InsertarEn(raiz, clave, dato);
        }

        private NodoArbol<T> InsertarEn(NodoArbol<T>? nodo, string clave, T dato)
        {
            if (nodo == null)
            {
                Cantidad++;
                return new NodoArbol<T>(clave, dato);                                       // lugar vacío: aquí va el nuevo nodo
            }

            int comparacion = string.CompareOrdinal(clave, nodo.Clave);
            if (comparacion < 0) nodo.Izquierdo = InsertarEn(nodo.Izquierdo, clave, dato);
            else if (comparacion > 0) nodo.Derecho = InsertarEn(nodo.Derecho, clave, dato);
            else nodo.Datos.AgregarFinal(dato);                                             // clave repetida: se guarda en el mismo nodo
            return nodo;
        }
        // buscar exactamente por lo que se escribe (no por inicio de clave)
        /// <summary>Devuelve los datos que tienen exactamente esa clave (lista vacía si no existe).</summary>
        public ListaSimple<T> Buscar(string clave)
        {
            NodoArbol<T>? nodo = BuscarNodo(raiz, clave);
            return nodo != null ? nodo.Datos : new ListaSimple<T>();                        // if (nodo != null) return nodo.Datos;
                                                                                            //  else return new ListaSimple<T>();
        }

        private NodoArbol<T>? BuscarNodo(NodoArbol<T>? nodo, string clave)
        {
            if (nodo == null) return null;                                                  // llegó a un lugar vacío: no existe
            int comparacion = string.CompareOrdinal(clave, nodo.Clave);
            if (comparacion == 0) return nodo;                                              // se encontró la clave
            if (comparacion < 0) return BuscarNodo(nodo.Izquierdo, clave);
            return BuscarNodo(nodo.Derecho, clave);
        }
        // buscar por inicio de clave (primera letras de la clave, no toda la clave)
        /// <summary>
        /// Devuelve los datos cuya clave EMPIEZA con el texto dado, ordenados por clave.
        /// Ejemplo: con "lec" encuentra "leche", "lechuga", "lecturas"...
        /// Solo recorre las ramas donde pueden estar, no todo el árbol.
        /// </summary>
        public ListaSimple<T> BuscarPorInicio(string inicio)
        {
            ListaSimple<T> resultado = new ListaSimple<T>();
            BuscarPorInicioEn(raiz, inicio, resultado);
            return resultado;
        }
        // método para recorrer el árbol y buscar por inicio de clave (recursivo)
        private void BuscarPorInicioEn(NodoArbol<T>? nodo, string inicio, ListaSimple<T> resultado)
        {
            if (nodo == null) return;
            string comienzoClave = nodo.Clave;
            if (comienzoClave.Length > inicio.Length) comienzoClave = comienzoClave.Substring(0, inicio.Length);    // Se compara el texto buscado con el comienzo de la clave del nodo (mismo largo)

            int comparacion = string.CompareOrdinal(inicio, comienzoClave);
            if (comparacion < 0)
            {
                BuscarPorInicioEn(nodo.Izquierdo, inicio, resultado);                       // lo buscado es menor: solo puede estar a la izquierda
            }
            else if (comparacion > 0)
            {
                BuscarPorInicioEn(nodo.Derecho, inicio, resultado);                         // lo buscado es mayor: solo puede estar a la derecha
            }
            else
            {
                // Este nodo coincide: también puede haber coincidencias a ambos lados (se guarda en orden)
                BuscarPorInicioEn(nodo.Izquierdo, inicio, resultado);
                foreach (T dato in nodo.Datos) resultado.AgregarFinal(dato);
                BuscarPorInicioEn(nodo.Derecho, inicio, resultado);
            }
        }
        // eliminar (clave exacta)
        /// <summary>Elimina la clave con todos sus datos. Devuelve true si la encontró.</summary>
        public bool Eliminar(string clave)
        {
            seElimino = false;
            raiz = EliminarEn(raiz, clave);
            if (seElimino) Cantidad--;
            return seElimino;
        }
        // eliminar exactamente un nodo del árbol (recursivo)
        private NodoArbol<T>? EliminarEn(NodoArbol<T>? nodo, string clave)
        {
            if (nodo == null) return null;

            int comparacion = string.CompareOrdinal(clave, nodo.Clave);
            if (comparacion < 0)
            {
                nodo.Izquierdo = EliminarEn(nodo.Izquierdo, clave);
            }
            else if (comparacion > 0)
            {
                nodo.Derecho = EliminarEn(nodo.Derecho, clave);
            }
            else
            {
                seElimino = true;

                // Caso 1 y 2: sin hijos o con un solo hijo, el hijo ocupa su lugar
                if (nodo.Izquierdo == null) return nodo.Derecho;
                if (nodo.Derecho == null) return nodo.Izquierdo;

                // Caso 3: con dos hijos, ocupa su lugar el menor del subárbol de la derecha (el sucesor)
                NodoArbol<T> sucesor = MenorDe(nodo.Derecho);
                nodo.Clave = sucesor.Clave;
                nodo.Datos = sucesor.Datos;
                nodo.Derecho = EliminarEn(nodo.Derecho, sucesor.Clave);                 // elimina el nodo del sucesor de su ubicación original en el subárbol derecho
            }
            return nodo;
        }
        // encuentra el menor de un subárbol (el más a la izquierda)
        private NodoArbol<T> MenorDe(NodoArbol<T> nodo)
        {
            if (nodo.Izquierdo == null) return nodo;
            return MenorDe(nodo.Izquierdo);                                             // Con while: while (nodo.Izquierdo != null) nodo = nodo.Izquierdo;  return nodo;
        }
        // recorrido (recursivo) para obtener todas las claves o todos los datos del árbol, en preorden, inorden o postorden
        /// <summary>Preorden: primero la raíz, luego la izquierda y luego la derecha.</summary>
        public ListaSimple<string> RecorrerPreorden()
        {
            ListaSimple<string> claves = new ListaSimple<string>();
            PreordenEn(raiz, claves);
            return claves;
        }
      
        private void PreordenEn(NodoArbol<T>? nodo, ListaSimple<string> claves)
        {
            if (nodo == null) return;
            claves.AgregarFinal(nodo.Clave);
            PreordenEn(nodo.Izquierdo, claves);
            PreordenEn(nodo.Derecho, claves);
        }

        /// <summary>Inorden: izquierda, raíz y derecha. Las claves salen ordenadas de menor a mayor.</summary>
        public ListaSimple<string> RecorrerInorden()
        {
            ListaSimple<string> claves = new ListaSimple<string>();
            InordenEn(raiz, claves);
            return claves;
        }

        private void InordenEn(NodoArbol<T>? nodo, ListaSimple<string> claves)
        {
            if (nodo == null) return;
            InordenEn(nodo.Izquierdo, claves);
            claves.AgregarFinal(nodo.Clave);
            InordenEn(nodo.Derecho, claves);
        }

        /// <summary>Postorden: izquierda, derecha y al final la raíz.</summary>
        public ListaSimple<string> RecorrerPostorden()
        {
            ListaSimple<string> claves = new ListaSimple<string>();
            PostordenEn(raiz, claves);
            return claves;
        }

        private void PostordenEn(NodoArbol<T>? nodo, ListaSimple<string> claves)
        {
            if (nodo == null) return;
            PostordenEn(nodo.Izquierdo, claves);
            PostordenEn(nodo.Derecho, claves);
            claves.AgregarFinal(nodo.Clave);
        }

        /// <summary>Todos los datos del árbol, ordenados por clave (recorrido inorden).</summary>
        public ListaSimple<T> TodosLosDatos()
        {
            ListaSimple<T> datos = new ListaSimple<T>();
            DatosInordenEn(raiz, datos);
            return datos;
        }

        private void DatosInordenEn(NodoArbol<T>? nodo, ListaSimple<T> datos)
        {
            if (nodo == null) return;
            DatosInordenEn(nodo.Izquierdo, datos);
            foreach (T dato in nodo.Datos) datos.AgregarFinal(dato);
            DatosInordenEn(nodo.Derecho, datos);
        }

        /// <summary>Altura del árbol: cantidad de niveles desde la raíz hasta la hoja más lejana.</summary>
        public int Altura()
        {
            return AlturaEn(raiz);
        }

        private int AlturaEn(NodoArbol<T>? nodo)
        {
            if (nodo == null) return 0;
            int alturaIzquierda = AlturaEn(nodo.Izquierdo);
            int alturaDerecha = AlturaEn(nodo.Derecho);
            return Math.Max(alturaIzquierda, alturaDerecha) + 1;                        // Con if: if (alturaIzquierda > alturaDerecha) return alturaIzquierda + 1;
                                                                                        //         else return alturaDerecha + 1;
        }

        public void Limpiar()
        {
            raiz = null;
            Cantidad = 0;
        }
    }
}
