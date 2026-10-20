using System.Collections;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Cola (FIFO): el primero que llega es el primero que sale.
    /// Se usa para las transacciones en espera, respetando el orden de llegada.
    /// </summary>
    public class Cola<T> : IEnumerable<T>
    {
        private Nodo<T>? frente;
        private Nodo<T>? final;
        public int Cantidad { get; private set; }

        public bool EstaVacia => frente == null;

        public void Encolar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            if (final == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
            Cantidad++;
        }

        public T? Desencolar()
        {
            if (frente == null) return default;
            T dato = frente.Dato;
            frente = frente.Siguiente;
            if (frente == null) final = null;    // la cola quedó vacía
            Cantidad--;
            return dato;
        }

        /// <summary>Mira quién sigue sin sacarlo.</summary>
        public T? Frente() => frente != null ? frente.Dato : default;

        public static Cola<T> Desde(IEnumerable<T> origen)
        {
            Cola<T> cola = new Cola<T>();
            foreach (T dato in origen) cola.Encolar(dato);
            return cola;
        }

        /// <summary>Recorre del frente al final (orden de llegada).</summary>
        public IEnumerator<T> GetEnumerator()
        {
            Nodo<T>? nodo = frente;
            while (nodo != null)
            {
                yield return nodo.Dato;
                nodo = nodo.Siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
