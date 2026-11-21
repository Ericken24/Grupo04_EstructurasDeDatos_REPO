using System.Collections;
using System.Collections.Generic;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras
{
    /// <summary>
    /// Lista enlazada simple. Se usa para catálogos y registros (productos, compras, gastos...).
    /// Implementa IEnumerable para poder usar foreach y LINQ sobre ella.
    /// </summary>
    public class ListaSimple<T> : IEnumerable<T>
    {
        private Nodo<T>? cabeza;  
        private Nodo<T>? ultimo;
        public int Cantidad { get; private set; }

        public bool EstaVacia => cabeza == null;   // if (cabeza == null) { return true; } else { return false; }

        // Agrega un nodo al inicio. El nuevo pasa a ser la cabeza y apunta a la cabeza anterior.
        public void AgregarInicio(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
            if (ultimo == null) ultimo = nuevo;
            Cantidad++;
        }

        // Agrega un nodo al final. El último actual apunta al nuevo y el nuevo pasa a ser el último.
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

        // Elimina el primer elemento que cumpla la condición (Predicate).
        /// Devuelve true si lo encontró y eliminó; false si no existía.
        /// Se recorre con dos punteros: "actual" y "anterior".
        public bool Eliminar(Predicate<T> condicion)
        {
            Nodo<T>? actual = cabeza;
            Nodo<T>? anterior = null;

            while (actual != null)
            {
                if (condicion(actual.Dato))   // ¿el dato cumple la condición?
                {
                    if (anterior == null) cabeza = actual.Siguiente;   // era la cabeza
                    else anterior.Siguiente = actual.Siguiente;        // estaba en medio o al final

                    if (actual == ultimo) ultimo = anterior;           // era el último
                    Cantidad--;
                    return true;
                }
                anterior = actual;              // avanzo "anterior"
                actual = actual.Siguiente;      // avanzo "actual"
            }
            return false;
        }

        // Devuelve el primer elemento que cumpla la condición, o default si no hay.
        public T? Buscar(Predicate<T> condicion)
        {
            Nodo<T>? actual = cabeza;
            while (actual != null)
            {
                if (condicion(actual.Dato)) return actual.Dato;
                actual = actual.Siguiente;
            }
            return default;   // para T? = null
        }

        // Devuelve una lista nueva solo con los elementos que cumplan la condición.
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

        // Borra todos los nodos y deja la lista vacía.
        public void Limpiar()
        {
            cabeza = null;
            ultimo = null;
            Cantidad = 0;
        }

        // Puente hacia List<T>;: para guardar en JSON o llenar un DataGridView/ComboBox. Para usamos el ToList(): convertir los datos en una lista. 
        // Se apoya en el foreach (que a su vez usa GetEnumerator).
        public List<T> ToList()
        {
            List<T> lista = new List<T>();
            foreach (T dato in this) lista.Add(dato);
            return lista;
        }

        // Puente desde cualquier colección (por ejemplo un List de LINQ): arma la lista enlazada.
        public static ListaSimple<T> Desde(IEnumerable<T> origen)
        {
            ListaSimple<T> lista = new ListaSimple<T>();
            foreach (T dato in origen) lista.AgregarFinal(dato);
            return lista;
        }

        // Permite recorrer la lista con foreach (de la cabeza al final).
        // Se copian los datos a un List<T>; y se devuelve su enumerador.
        public IEnumerator<T> GetEnumerator()
        {
            List<T> datos = new List<T>();
            Nodo<T>? actual = cabeza;
            while (actual != null)
            {
                datos.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return datos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();   // devuelve todos los datos de la lista ya ordenados
    }
}