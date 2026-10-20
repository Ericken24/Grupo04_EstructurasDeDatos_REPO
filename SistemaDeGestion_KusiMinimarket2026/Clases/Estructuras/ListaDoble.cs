using System.Collections;

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

        /// <summary>Dato donde está parado el cursor (default si la lista está vacía).</summary>
        public T? DatoActual => actual != null ? actual.Dato : default;

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

        public bool IrSiguiente()
        {
            if (actual?.Siguiente == null) return false;
            actual = actual.Siguiente;
            return true;
        }

        public bool IrAnterior()
        {
            if (actual?.Anterior == null) return false;
            actual = actual.Anterior;
            return true;
        }

        public void IrAlInicio() => actual = cabeza;
        public void IrAlFinal() => actual = cola;

        /// <summary>Recorre la lista de atrás hacia adelante (útil para mostrar lo más reciente primero).</summary>
        public IEnumerable<T> RecorrerAlReves()
        {
            NodoDoble<T>? nodo = cola;
            while (nodo != null)
            {
                yield return nodo.Dato;
                nodo = nodo.Anterior;
            }
        }

        public static ListaDoble<T> Desde(IEnumerable<T> origen)
        {
            ListaDoble<T> lista = new ListaDoble<T>();
            foreach (T dato in origen) lista.AgregarFinal(dato);
            return lista;
        }

        public IEnumerator<T> GetEnumerator()
        {
            NodoDoble<T>? nodo = cabeza;
            while (nodo != null)
            {
                yield return nodo.Dato;
                nodo = nodo.Siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
