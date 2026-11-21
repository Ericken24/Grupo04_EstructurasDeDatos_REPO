namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Nodo simple: guarda un dato y apunta al siguiente.
    /// Es la pieza básica de la lista simple, la lista circular, la cola y la pila.
    /// </summary>
    public class Nodo<T>
    {
        public T Dato;                
        public Nodo<T>? Siguiente;    

        // Constructor: crea un nodo nuevo con el dato recibido.
        public Nodo(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Nodo doble: apunta al siguiente y al anterior.
    public class NodoDoble<T>
    {
        public T Dato;                      
        public NodoDoble<T>? Siguiente;     
        public NodoDoble<T>? Anterior;      

        // Constructor: crea un nodo doble con el dato recibido.
        public NodoDoble(T dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}