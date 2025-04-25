using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1.DB
{
    public class BDchurro
    {
        private string _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=tu_contraseña;Database=ChurrosDB";

        public List<string> ObtenerProductos()
        {
            var productos = new List<string>();

            // Conexión a la base de datos
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            // Ejecutar la consulta
            using var cmd = new NpgsqlCommand("SELECT nombre FROM productos", conn);
            using var reader = cmd.ExecuteReader();

            // Leer los resultados
            while (reader.Read())
            {
                var nombre = reader.GetString(0);
                productos.Add(nombre);
            }

            return productos;
        }
    }
}
