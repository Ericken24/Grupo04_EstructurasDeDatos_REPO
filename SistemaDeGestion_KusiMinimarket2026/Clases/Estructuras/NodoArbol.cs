namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Nodo del árbol binario de búsqueda: guarda una clave (texto) y los datos que tienen esa clave.
    /// Los menores van a la izquierda y los mayores a la derecha.
    /// Si dos datos tienen la misma clave (por ejemplo, dos productos con la palabra "leche"),
    /// se guardan juntos en la lista Datos del mismo nodo.
    /// </summary>
    public class NodoArbol<T>
    {
        public string Clave;                                // clave es el código o la palabra que se usa para buscar el dato
        public ListaSimple<T> Datos;                        // lista de todos los datos que tienen esa clave (por ejemplo, dos productos con la palabra "leche")
        public NodoArbol<T>? Izquierdo;
        public NodoArbol<T>? Derecho;

        public NodoArbol(string clave, T dato)
        {
            Clave = clave;
            Datos = new ListaSimple<T>();
            Datos.AgregarFinal(dato);
            Izquierdo = null;
            Derecho = null;
        }
    }
}
