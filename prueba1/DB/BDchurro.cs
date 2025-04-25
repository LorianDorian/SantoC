
/*
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
*/

using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

public class MenuItem
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

public class DatabaseService
{
    private SQLiteAsyncConnection _db;

    public async Task InitAsync()
    {
        if (_db != null)
            return;

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "menu.db");
        _db = new SQLiteAsyncConnection(dbPath);
        await _db.CreateTableAsync<MenuItem>();
    }

    public async Task<List<MenuItem>> GetMenuItemsAsync()
    {
        await InitAsync();
        return await _db.Table<MenuItem>().ToListAsync();
    }

    public async Task AddMenuItemAsync(MenuItem item)
    {
        await InitAsync();
        await _db.InsertAsync(item);
    }

    public async Task SeedDataAsync()
    {
        var count = (await GetMenuItemsAsync()).Count;
        if (count == 0)
        {
            await AddMenuItemAsync(new MenuItem { Name = "Cheeseburger", Price = 5.99 });
            await AddMenuItemAsync(new MenuItem { Name = "Veggie Wrap", Price = 4.49 });
        }
    }
}