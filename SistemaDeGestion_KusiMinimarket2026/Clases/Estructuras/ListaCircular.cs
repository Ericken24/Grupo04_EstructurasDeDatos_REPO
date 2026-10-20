using System.Collections;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Lista enlazada circular simple: el último nodo apunta de nuevo al primero.
    /// Se usa para rotar entre sucursales al reintentar sincronizaciones.
    /// Se guarda solo "ultimo": ultimo.Siguiente es siempre la cabeza.
    /// </summary>
    public class ListaCircular<T> : IEnumerable<T>
    {
        private Nodo<T>? ultimo;
        private Nodo<T>? turno;          // nodo al que le toca en la rotación
        public int Cantidad { get; private set; }

        public bool EstaVacia => ultimo == null;

        public void Agregar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            if (ultimo == null)
            {
                nuevo.Siguiente = nuevo;     // se apunta a sí mismo
                ultimo = nuevo;
                turno = nuevo;
            }
            else
            {
                nuevo.Siguiente = ultimo.Siguiente;   // el nuevo apunta a la cabeza
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            Cantidad++;
        }

        /// <summary>Devuelve el elemento del turno y pasa al siguiente. Al llegar al final, vuelve al inicio.</summary>
        public T? SiguienteTurno()
        {
            if (turno == null) return default;
            T dato = turno.Dato;
            turno = turno.Siguiente;
            return dato;
        }

        /// <summary>Recorre una sola vuelta (se detiene al volver a la cabeza para no entrar en bucle infinito).</summary>
        public IEnumerator<T> GetEnumerator()
        {
            if (ultimo == null) yield break;
            Nodo<T> nodo = ultimo.Siguiente!;
            for (int i = 0; i < Cantidad; i++)
            {
                yield return nodo.Dato;
                nodo = nodo.Siguiente!;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
