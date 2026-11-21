using System.Collections;
using System.Collections.Generic;

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
        private Nodo<T>? turno;
        public int Cantidad { get; private set; }

        public bool EstaVacia => ultimo == null;


        // Agrega un nodo al final de la circular.
        public void Agregar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            if (ultimo == null)
            {
                nuevo.Siguiente = nuevo;
                ultimo = nuevo;
                turno = nuevo;
            }
            else
            {
                nuevo.Siguiente = ultimo.Siguiente;
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            Cantidad++;
        }

        // Devuelve el elemento del turno y pasa al siguiente.
        public T? SiguienteTurno()
        {
            if (turno == null) return default;
            T dato = turno.Dato;
            turno = turno.Siguiente;
            return dato;
        }

        // Recorre una sola vuelta (se detiene al volver a la cabeza para no entrar en bucle infinito).
        // Se copian los datos a un List<T>; con un for de "Cantidad" vueltas.
        public IEnumerator<T> GetEnumerator()
        {
            List<T> datos = new List<T>();
            if (ultimo != null)
            {
                Nodo<T> nodo = ultimo.Siguiente!;
                for (int i = 0; i < Cantidad; i++)
                {
                    datos.Add(nodo.Dato);
                    nodo = nodo.Siguiente!;
                }
            }
            return datos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();         // devuelve todos los datos de la lista ya ordenados
    }
}