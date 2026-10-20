namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>Nodo simple: guarda un dato y apunta al siguiente.</summary>
    public class Nodo<T>
    {
        public T Dato;
        public Nodo<T>? Siguiente;

        public Nodo(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    /// <summary>Nodo doble: apunta al siguiente y al anterior.</summary>
    public class NodoDoble<T>
    {
        public T Dato;
        public NodoDoble<T>? Siguiente;
        public NodoDoble<T>? Anterior;

        public NodoDoble(T dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}
