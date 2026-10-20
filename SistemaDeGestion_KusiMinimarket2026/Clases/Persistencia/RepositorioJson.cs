using System.Text.Encodings.Web;
using System.Text.Json;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia
{
    /// <summary>
    /// Lee y escribe una lista de objetos en un archivo JSON de la carpeta Datos.
    /// Una sola clase sirve para todos los modelos: new RepositorioJson&lt;Producto&gt;("productos.json").
    /// </summary>
    public class RepositorioJson<T>
    {
        private static readonly JsonSerializerOptions opciones = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping   // para que las tildes no salgan como \u00F3
        };

        private readonly string ruta;

        public RepositorioJson(string nombreArchivo)
        {
            ruta = Path.Combine(Almacen.CarpetaDatos, nombreArchivo);
        }

        /// <summary>Lee el archivo completo. Si no existe o está vacío, devuelve una lista vacía.</summary>
        public List<T> Cargar()
        {
            if (!File.Exists(ruta)) return new List<T>();

            // Reintenta por si otro equipo/proceso está escribiendo el archivo en ese instante
            for (int intento = 1; intento <= 5; intento++)
            {
                try
                {
                    using FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    List<T>? datos = JsonSerializer.Deserialize<List<T>>(fs, opciones);
                    return datos ?? new List<T>();
                }
                catch (IOException) when (intento < 5)
                {
                    Thread.Sleep(100);
                }
            }
            return new List<T>();
        }

        /// <summary>Guarda toda la lista. Escribe primero en un temporal y luego lo reemplaza, para no dejar un JSON a medias.</summary>
        public void Guardar(IEnumerable<T> datos)
        {
            Directory.CreateDirectory(Almacen.CarpetaDatos);
            string temporal = ruta + "." + Guid.NewGuid().ToString("N") + ".tmp";
            File.WriteAllText(temporal, JsonSerializer.Serialize(datos, opciones));

            for (int intento = 1; intento <= 5; intento++)
            {
                try
                {
                    File.Move(temporal, ruta, true);
                    return;
                }
                catch (IOException) when (intento < 5)
                {
                    Thread.Sleep(100);
                }
            }
        }

        /// <summary>Agrega un registro leyendo primero lo más reciente del archivo (así no se pisan los datos de otros).</summary>
        public void Agregar(T item)
        {
            List<T> datos = Cargar();
            datos.Add(item);
            Guardar(datos);
        }

        /// <summary>Siguiente ID libre: el mayor existente + 1.</summary>
        public static int SiguienteId(IEnumerable<int> idsExistentes)
        {
            int max = 0;
            foreach (int id in idsExistentes)
                if (id > max) max = id;
            return max + 1;
        }
    }
}
