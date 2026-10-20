using System.Collections;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Pila (LIFO): el último que entra es el primero que sale.
    /// Se usa para deshacer el último producto agregado al carrito y para revertir la última venta.
    /// </summary>
    public class Pila<T> : IEnumerable<T>
    {
        private Nodo<T>? tope;
        public int Cantidad { get; private set; }

        public bool EstaVacia => tope == null;

        public void Apilar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            nuevo.Siguiente = tope;
            tope = nuevo;
            Cantidad++;
        }

        public T? Desapilar()
        {
            if (tope == null) return default;
            T dato = tope.Dato;
            tope = tope.Siguiente;
            Cantidad--;
            return dato;
        }

        /// <summary>Mira el tope sin sacarlo.</summary>
        public T? Cima() => tope != null ? tope.Dato : default;

        public void Limpiar()
        {
            tope = null;
            Cantidad = 0;
        }

        /// <summary>Recorre desde el tope hacia abajo.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            Nodo<T>? nodo = tope;
            while (nodo != null)
            {
                yield return nodo.Dato;
                nodo = nodo.Siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
