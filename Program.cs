using CAP001_CreacionDocumentoPDF;

try
{
string filePath = "c:\\temp\\ListadoArticulos.pdf";
    // Leer una cadenas de texto que seran las credenciales del acceso a la base de datos
    Console.Write("Ingresar usuario de conexion a la base de datos: ");
    string input_usuario_oracle_connect = Console.ReadLine();
    Console.Write("Ingresar password de conexion a la base de datos: ");
    string input_password_oracle_connect = Console.ReadLine();
    Console.Write("Ingresar ip de conexion a la base de datos: ");
    string input_ip_server_bd_oracle_connect = Console.ReadLine();
    Console.Write("Ingresar puerto de conexion a la base de datos: ");
    string input_puerto_server_bd_oracle_connect = Console.ReadLine();
    Console.Write("Ingresar name de conexion a la base de datos: ");
    string input_name_server_bd_oracle_connect = Console.ReadLine();
    // Definir la cadena de conexión
    string connectionString = $"User Id={input_usuario_oracle_connect};Password={input_password_oracle_connect};Data Source=//{input_ip_server_bd_oracle_connect}:{input_puerto_server_bd_oracle_connect}/{input_name_server_bd_oracle_connect}";
    // Impresion de resultado
    Console.WriteLine("Conectando a la base de datos. No cierre la consola.");
    var oracleService = new OracleService(connectionString);
    // Crear una lista de productos
    Console.WriteLine("Ejecutando la lectura de articulos. No cierre la consola.");
    List<Articulo> articulos = oracleService.GetArticulos();
    PDFService pdfService = new PDFService();
    // Crear Archivo PDF
    Console.WriteLine("Creando Archivo PDF. No cierre la consola.");
    pdfService.CreatePDF(filePath, articulos);

    Console.WriteLine("PDF creado exitosamente en: " + filePath);

}
catch (Exception ex)
{
    Console.WriteLine("Ocurrio un error: " + ex.ToString());
	throw;
}







