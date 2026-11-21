namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Un dato guardado en el índice junto con todo su texto (ya en minúsculas) y una marca
    /// que se usa para no devolver el mismo dato dos veces en una búsqueda.
    /// </summary>
    public class EntradaIndice<T>
    {
        public T Dato;
        public string Texto = "";
        public int MarcaBusqueda;

        public EntradaIndice(T dato)
        {
            Dato = dato;
        }
    }

    /// <summary>
    /// Índice de búsqueda: funciona como el índice de un libro. Cada código y cada palabra
    /// de un dato es una clave dentro de un árbol binario de búsqueda (ABB) que apunta a ese dato.
    /// Un mismo índice sirve para buscar por código o por texto en cualquier buscador.
    ///
    /// Uso:
    ///     IndiceBusqueda&lt;Producto&gt; indice = new IndiceBusqueda&lt;Producto&gt;();
    ///     foreach (Producto p in productos) indice.Agregar(p, new string?[] { p.SKU, p.Nombre });
    ///     ListaSimple&lt;Producto&gt; encontrados = indice.Buscar(txtBuscar.Text);
    /// </summary>
    public class IndiceBusqueda<T>
    {
        private readonly ArbolBinarioBusqueda<EntradaIndice<T>> arbol = new ArbolBinarioBusqueda<EntradaIndice<T>>();           // el ABB guarda las claves (códigos y palabras) y apunta a los datos
        private readonly ListaSimple<EntradaIndice<T>> entradas = new ListaSimple<EntradaIndice<T>>();                          // la lista de todas las entradas (cada entrada tiene su texto completo y su marca de búsqueda)
        private readonly ListaSimple<T> todos = new ListaSimple<T>();                                                           // la lista de todos los datos guardados en el índice
        private int numeroBusqueda;

        /// <summary>Cantidad de datos guardados en el índice.</summary>
        public int Cantidad => todos.Cantidad;

        // Armar el índice: agregar datos y sus textos (códigos, nombres, etc.) como claves en el árbol
        /// <summary>
        /// Guarda un dato en el índice. "textos" son los campos por los que se podrá buscar
        /// (código, SKU, nombre...). Los vacíos o nulos se ignoran.
        /// </summary>
        public void Agregar(T dato, string?[] textos)
        {
            EntradaIndice<T> entrada = new EntradaIndice<T>(dato);

            foreach (string? texto in textos)
            {
                if (string.IsNullOrWhiteSpace(texto)) continue;

                string limpio = texto.Trim().ToLower();                                                 //  Trim().ToLower: quita espacios al inicio y al final, y pasa a minúsculas para que la búsqueda no sea sensible a mayúsculas
                entrada.Texto = entrada.Texto + " " + limpio;                                           
                                                                                     
                arbol.Insertar(limpio, entrada);                                                        // El texto completo es una clave (sirve para códigos como "pro-0001")

                foreach (string palabra in SepararPalabras(limpio))                                     // Cada palabra suelta también es una clave (sirve para buscar por nombre)
                {
                    if (palabra != limpio) arbol.Insertar(palabra, entrada);
                }
            }

            entradas.AgregarFinal(entrada);
            todos.AgregarFinal(dato);
        }

        // Separar palabras: se usa para que cada palabra de un nombre sea una clave en el árbol, ejemplo: "Leche entera 1L" -> "leche", "entera", "1l"
        /// <summary>Parte un texto en palabras: una palabra son letras o números seguidos.</summary>
        private static List<string> SepararPalabras(string texto)
        {
            List<string> palabras = new List<string>();
            string actual = "";

            foreach (char letra in texto)
            {
                if (char.IsLetterOrDigit(letra))                                                        // letras y números se agregan a la palabra actual
                {
                    actual = actual + letra;                                                            
                }
                else
                {
                    if (actual.Length > 0) palabras.Add(actual);                                        // un símbolo o espacio cierra la palabra
                    actual = "";
                }
            }

            if (actual.Length > 0) palabras.Add(actual);
            return palabras;
        }

        // Buscar: por código o por texto
        /// <summary>
        /// Busca por código o por texto. Encuentra los datos que tengan un código o una palabra
        /// que EMPIECE con lo escrito. Si no encuentra nada, revisa todo el texto de cada dato
        /// (como la búsqueda anterior) para no dejar al usuario sin resultados.
        /// Sin texto devuelve todos los datos.
        /// </summary>
        public ListaSimple<T> Buscar(string texto)
        {
            string buscado = texto.Trim().ToLower();
            if (buscado.Length == 0) return todos;
            List<string> palabras = SepararPalabras(buscado);                                           // Se usa la primera palabra escrita para entrar al árbol
            
            string inicio = palabras.Count > 0 ? palabras[0] : buscado;                                 // Con if: string inicio; if (palabras.Count > 0) inicio = palabras[0];
                                                                                                        // else inicio = buscado;

            numeroBusqueda++;                                                                           // cada búsqueda tiene su propio número
            ListaSimple<T> resultado = new ListaSimple<T>();

            ListaSimple<EntradaIndice<T>> candidatas = arbol.BuscarPorInicio(inicio);
            foreach (EntradaIndice<T> entrada in candidatas)
            {
                if (entrada.MarcaBusqueda == numeroBusqueda) continue;                                  // ya se encuentrá en el resultado, ejemplo: "leche" y "leche entera" apuntan al mismo dato, no se repite
                entrada.MarcaBusqueda = numeroBusqueda;

                if (buscado != inicio && !entrada.Texto.Contains(buscado)) continue;                    // Si se escribió más de una palabra (o un código con guion), se confirma con el texto completo
                resultado.AgregarFinal(entrada.Dato);
            }

            if (!resultado.EstaVacia) return resultado;
            return BuscarRevisandoTodo(buscado);
        }

        /// <summary>Plan B: revisa dato por dato si el texto aparece en cualquier parte.</summary>
        private ListaSimple<T> BuscarRevisandoTodo(string buscado)
        {
            ListaSimple<T> resultado = new ListaSimple<T>();
            foreach (EntradaIndice<T> entrada in entradas)
            {
                if (entrada.Texto.Contains(buscado)) resultado.AgregarFinal(entrada.Dato);
            }
            return resultado;
        }

        /// <summary>Busca un código exacto (por ejemplo un SKU o un código de barras). Devuelve el dato o null.</summary>
        public T? BuscarPorCodigo(string codigo)
        {
            ListaSimple<EntradaIndice<T>> encontradas = arbol.Buscar(codigo.Trim().ToLower());
            foreach (EntradaIndice<T> entrada in encontradas) return entrada.Dato;                      // devuelve el primer dato encontrado (si hay más de uno, se ignoran los demás)
            return default;
        }

        public void Limpiar()
        {
            arbol.Limpiar();
            entradas.Limpiar();
            todos.Limpiar();
        }
    }
}
