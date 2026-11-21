using System.Collections;
using System.Collections.Generic;

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

        // Agrega un elemento al final. Si estaba vacía, el nuevo es frente y final a la vez.
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

        // Saca el elemento del frente y lo devuelve. Si estaba vacía, devuelve default.
        public T? Desencolar()
        {
            if (frente == null) return default;
            T dato = frente.Dato;
            frente = frente.Siguiente;
            if (frente == null) final = null;
            Cantidad--;
            return dato;
        }

        // Ver que nodo sigue sin eliminarlo
        public T? Frente() => frente != null ? frente.Dato : default;               // { if (frente != null) return frente.Dato; else return default; }


        // Limpiar la cola completa
        public void Limpiar()
        {
            frente = null;
            final = null;
            Cantidad = 0;
        }

        // Construye una Cola a partir de cualquier colección (en este caso una lista)
        public static Cola<T> Desde(IEnumerable<T> origen)
        {
            Cola<T> cola = new Cola<T>();
            foreach (T dato in origen) cola.Encolar(dato);
            return cola;
        }

        // Recorre del frente al final (orden de llegada).
        /// Se copian los datos a un List<T>; y se devuelve su enumerador.
        public IEnumerator<T> GetEnumerator()
        {
            List<T> datos = new List<T>();
            Nodo<T>? nodo = frente;
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