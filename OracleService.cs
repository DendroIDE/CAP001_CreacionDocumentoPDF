using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP001_CreacionDocumentoPDF
{
    public class OracleService : IDisposable
    {
        private OracleConnection _connection;

        public OracleService(string connectionString)
        {
            _connection = new OracleConnection(connectionString);
        }

        // Método para abrir la conexión
        public OracleConnection GetConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }

        // Ejemplo de consulta de datos
        public List<Producto> GetProducts()
        {
            string query = "SELECT * FROM ALM_ARTICULOS";
            using (var command = new OracleCommand(query, GetConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Crear una instancia de Producto y asignar los valores de las columnas
                        var producto = new Producto
                        {
                            Codigo = reader.GetInt32(0),      // Primera columna: ID
                            Nombre = reader.GetString(1),  // Segunda columna: NOMBRE
                            PrecioUnitario = reader.GetDecimal(2),
                            Cantidad = reader.GetInt32(3)
                            
                        };
                        productos.Add(producto);
                    }
                }
            }
            return productos
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
                _connection.Dispose();
            }
        }
    }
}
