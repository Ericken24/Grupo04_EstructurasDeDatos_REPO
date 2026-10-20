using System.Collections;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Lista enlazada simple. Se usa para catálogos y registros (productos, compras, gastos...).
    /// Implementa IEnumerable para poder usar foreach y LINQ sobre ella.
    /// </summary>
    public class ListaSimple<T> : IEnumerable<T>
    {
        private Nodo<T>? cabeza;
        private Nodo<T>? ultimo;     // guardar el último evita recorrer toda la lista al agregar
        public int Cantidad { get; private set; }

        public bool EstaVacia => cabeza == null;

        public void AgregarInicio(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
            if (ultimo == null) ultimo = nuevo;
            Cantidad++;
        }

        public void AgregarFinal(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo!.Siguiente = nuevo;
                ultimo = nuevo;
            }
            Cantidad++;
        }

        /// <summary>Elimina el primer elemento que cumpla la condición. Devuelve true si lo encontró.</summary>
        public bool Eliminar(Predicate<T> condicion)
        {
            Nodo<T>? actual = cabeza;
            Nodo<T>? anterior = null;

            while (actual != null)
            {
                if (condicion(actual.Dato))
                {
                    if (anterior == null) cabeza = actual.Siguiente;   // era la cabeza
                    else anterior.Siguiente = actual.Siguiente;

                    if (actual == ultimo) ultimo = anterior;           // era el último
                    Cantidad--;
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            return false;
        }

        /// <summary>Devuelve el primer elemento que cumpla la condición, o default si no hay.</summary>
        public T? Buscar(Predicate<T> condicion)
        {
            Nodo<T>? actual = cabeza;
            while (actual != null)
            {
                if (condicion(actual.Dato)) return actual.Dato;
                actual = actual.Siguiente;
            }
            return default;
        }

        /// <summary>Devuelve una lista nueva solo con los elementos que cumplan la condición.</summary>
        public ListaSimple<T> Filtrar(Predicate<T> condicion)
        {
            ListaSimple<T> resultado = new ListaSimple<T>();
            Nodo<T>? actual = cabeza;
            while (actual != null)
            {
                if (condicion(actual.Dato)) resultado.AgregarFinal(actual.Dato);
                actual = actual.Siguiente;
            }
            return resultado;
        }

        public void Limpiar()
        {
            cabeza = null;
            ultimo = null;
            Cantidad = 0;
        }

        /// <summary>Puente hacia List&lt;T&gt;: para guardar en JSON o llenar un DataGridView/ComboBox.</summary>
        public List<T> ToList()
        {
            List<T> lista = new List<T>();
            foreach (T dato in this) lista.Add(dato);
            return lista;
        }

        /// <summary>Puente desde List&lt;T&gt;: al cargar un JSON se arma la lista enlazada.</summary>
        public static ListaSimple<T> Desde(IEnumerable<T> origen)
        {
            ListaSimple<T> lista = new ListaSimple<T>();
            foreach (T dato in origen) lista.AgregarFinal(dato);
            return lista;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Nodo<T>? actual = cabeza;
            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.Siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
