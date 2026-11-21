using System.Collections;
using System.Collections.Generic;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Lista enlazada doble con un "cursor" (Actual). Se usa para el historial de ventas:
    /// los botones Anterior / Siguiente mueven el cursor en ambos sentidos.
    /// </summary>
    public class ListaDoble<T> : IEnumerable<T>
    {
        private NodoDoble<T>? cabeza;
        private NodoDoble<T>? cola;
        private NodoDoble<T>? actual;
        public int Cantidad { get; private set; }

        public bool EstaVacia => cabeza == null;
        public bool TieneAnterior => actual?.Anterior != null;
        public bool TieneSiguiente => actual?.Siguiente != null;

        /// Dato donde está parado el cursor (default si la lista está vacía).
        public T? DatoActual => actual != null ? actual.Dato : default;

        // Agrega un nodo al final. Si estaba vacía, el nuevo es cabeza, cola y cursor.
        public void AgregarFinal(T dato)
        {
            NodoDoble<T> nuevo = new NodoDoble<T>(dato);
            if (cabeza == null)                  
            {
                cabeza = nuevo;
                cola = nuevo;
                actual = nuevo;                  
            }
            else                                 
            {
                cola!.Siguiente = nuevo;
                nuevo.Anterior = cola;
                cola = nuevo;
            }
            Cantidad++;
        }

        // Agrega un nodo al inicio. Si estaba vacía, el nuevo es cabeza, cola y cursor.
        public void AgregarInicio(T dato)
        {
            NodoDoble<T> nuevo = new NodoDoble<T>(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
                cola = nuevo;
                actual = nuevo;
            }
            else
            {
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
                cabeza = nuevo;
            }
            Cantidad++;
        }

        // Mueve el cursor un nodo hacia adelante. Devuelve false si ya no hay siguiente.
        public bool IrSiguiente()
        {
            if (actual?.Siguiente == null) return false;
            actual = actual.Siguiente;
            return true;
        }

        // Mueve el cursor un nodo hacia atrás. Devuelve false si ya no hay anterior.
        public bool IrAnterior()
        {
            if (actual?.Anterior == null) return false;
            actual = actual.Anterior;
            return true;
        }

        public void IrAlInicio() => actual = cabeza;   // { actual = cabeza; }
        public void IrAlFinal() => actual = cola;      // { actual = cola;  }

        // Recorre la lista de atrás hacia adelante (útil para mostrar lo más reciente primero).
        /// Se copian los datos a un List<T>; recorriendo con "Anterior" y se devuelve ese List.
        public IEnumerable<T> RecorrerAlReves()
        {
            List<T> datos = new List<T>();
            NodoDoble<T>? nodo = cola;
            while (nodo != null)
            {
                datos.Add(nodo.Dato);
                nodo = nodo.Anterior;
            }
            return datos;
        }

        /// <summary>
        /// Construye una ListaDoble a partir de cualquier colección (por ejemplo, un List de LINQ).
        /// </summary>
        public static ListaDoble<T> Desde(IEnumerable<T> origen)
        {
            ListaDoble<T> lista = new ListaDoble<T>();
            foreach (T dato in origen) lista.AgregarFinal(dato);
            return lista;
        }

        /// <summary>
        /// Permite recorrer la lista con foreach (de la cabeza a la cola).
        /// Se copian los datos a un List&lt;T&gt; y se devuelve su enumerador.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            List<T> datos = new List<T>();
            NodoDoble<T>? nodo = cabeza;
            while (nodo != null)
            {
                datos.Add(nodo.Dato);
                nodo = nodo.Siguiente;
            }
            return datos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();         // devuelve todos los datos de la lista ya ordenados
    }
}