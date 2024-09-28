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
        public List<Articulo> GetArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();

            string query = @"SELECT T.ARTICULO CODIGO,
       T.NOMBRE,
       PKGENERAL.F_ARTICULO_EXISTENCIA(T.GRAR_COMPANIA,
                                       T.GRAR_CLASE,
                                       T.GRAR_CODIGRUP,
                                       T.ARTICULO,
                                       SYSDATE,
                                       '001') EXISTENCIA,
       V.PRECVENT PVP,
       A.SECC_CODIBODE UBICACION,
       T.VIGENTE,
       T.IMAGEN1
  FROM ALM_ARTICULOS T, ALM_UBICACION A, VEN_PRECDESC V
 WHERE T.ARTICULO = A.ARTL_ARTICULO
   AND V.ARTL_ARTICULO = T.ARTICULO
   AND T.GRAR_CLASE = 'INVR'
   AND A.SECC_OFICINA = '001'
   AND A.VIGENTE = 'S'
   AND V.LSPR_LSPR_ID = '0'
   AND T.GRAR_CODIGRUP = '03'
 ORDER BY VIGENTE DESC, CODIGO ASC";
            using (var command = new OracleCommand(query, GetConnection()))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verifica si el campo 'Vigente' es NULL antes de leerlo
                        byte[]? imagen = null;
                        if (!reader.IsDBNull(6))
                        {
                            using (var blob = reader.GetOracleBlob(6)) // Lee el campo como BLOB
                            {
                                imagen = blob.Value; // Asigna el valor del BLOB como un array de bytes
                            }
                        }
                        // Crear una instancia de Producto y asignar los valores de las columnas
                        var articulo = new Articulo
                        {
                            Codigo = reader.GetString(0),
                            Nombre = reader.GetString(1),
                            Existencia = reader.GetDecimal(2),
                            Pvp = reader.GetDecimal(3),
                            Ubicacion = reader.GetString(4),
                            Vigente = reader.GetString(5)[0],
                            Imagen = imagen
                        };
                        articulos.Add(articulo);
                    }
                }
            }
            return articulos;
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
