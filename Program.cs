using CAP001_CreacionDocumentoPDF;

try
{
    
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
    // Variables de creacion del archivo
    string filePath;
    bool archivoCreado = false;
    // Ciclo de creacion del archivo
    while (!archivoCreado)
    {
        // Preguntar la ruta donde se guardara el archivo
        Console.WriteLine("Por favor, introduce la ruta completa donde deseas guardar el archivo PDF (incluyendo el nombre del archivo).");
        Console.WriteLine("Ejemplo: C:\\Users\\Usuario\\Documents\\mi_archivo.pdf");
        Console.Write("Ruta: ");
        // Capturar la entrada de la ruta
        filePath = Console.ReadLine();
        // Validar la ruta del archivo
        if (string.IsNullOrWhiteSpace(filePath) || !Path.GetExtension(filePath).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("La ruta del archivo no es válida. Asegúrate de que incluya el nombre del archivo y la extensión .pdf.");
        }
        else
        {
            // Lógica para guardar el archivo PDF
            try
            {
                // Crear Archivo PDF
                Console.WriteLine("Creando Archivo PDF. No cierre la consola.");
                pdfService.CreatePDF(filePath, articulos);
                Console.WriteLine("El archivo se ha guardado correctamente en: " + filePath);
                // Salir del bucle ya que el archivo se creó exitosamente
                archivoCreado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al guardar el archivo: " + ex.Message);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrio un error: " + ex.Message);
	throw;
}







