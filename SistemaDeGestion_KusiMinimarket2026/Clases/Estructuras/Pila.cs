using System.Collections;
using System.Collections.Generic;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Pila (LIFO): el último que entra es el primero que sale.
    /// Se usa para deshacer el último producto agregado al carrito y para revertir la última venta.
    /// </summary>
    public class Pila<T> : IEnumerable<T>                                   // IEnumerable: permite recorrer la pila con foreach
    {
        private Nodo<T>? tope;                    
        public int Cantidad { get; private set; } 

        public bool EstaVacia => tope == null;  

        // Apila un nuevo elemento en la cima.
        /// El nuevo nodo pasa a ser el tope y su Siguiente es el tope anterior.
        public void Apilar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            nuevo.Siguiente = tope;
            tope = nuevo;
            Cantidad++;
        }

        // Desapila el elemento de la cima y lo devuelve. Si estaba vacía, devuelve default.
        public T? Desapilar()
        {
            if (tope == null) return default;
            T dato = tope.Dato;
            tope = tope.Siguiente;
            Cantidad--;
            return dato;
        }

        // Ver el tope sin desapilarlo
        public T? Cima() => tope != null ? tope.Dato : default;                 // { if (tope != null) return tope.Dato; else return default; }


        // Vaciar la pila completa
        public void Limpiar()
        {
            tope = null;
            Cantidad = 0;
        }

        // Recorre desde el tope hacia abajo (LIFO: el primero que sale, primero se muestra).
        /// Se copian los datos a un List<T>; y se devuelve su enumerador.
        public IEnumerator<T> GetEnumerator()
        {
            List<T> datos = new List<T>();
            Nodo<T>? nodo = tope;
            while (nodo != null)
            {
                datos.Add(nodo.Dato);
                nodo = nodo.Siguiente;
            }
            return datos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();             // devuelve todos los datos de la lista ya ordenados
    }
}