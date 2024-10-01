using CAP001_CreacionDocumentoPDF;

string filePath = "c:\\temp\\ListadoArticulos.pdf";

// Leer una cadenas de texto que seran las credenciales del acceso a la base de datos
Console.WriteLine("Ingresar usuario de conexion a la base de datos: ");
string input_usuario_oracle_connect = Console.ReadLine();
Console.WriteLine("Ingresar password de conexion a la base de datos: ");
string input_password_oracle_connect = Console.ReadLine();
Console.WriteLine("Ingresar ip de conexion a la base de datos: ");
string input_ip_server_bd_oracle_connect = Console.ReadLine();
Console.WriteLine("Ingresar puerto de conexion a la base de datos: ");
string input_puerto_server_bd_oracle_connect = Console.ReadLine();
Console.WriteLine("Ingresar name de conexion a la base de datos: ");
string input_name_server_bd_oracle_connect = Console.ReadLine();

// Definir la cadena de conexión
string connectionString = $"User Id={input_usuario_oracle_connect};Password={input_password_oracle_connect};Data Source=//{input_ip_server_bd_oracle_connect}:{input_puerto_server_bd_oracle_connect}/{input_name_server_bd_oracle_connect}";

var oracleService = new OracleService(connectionString);

    // Llamar al método que ejecuta una consulta   

// Crear una lista de productos
List<Articulo> articulos = oracleService.GetArticulos();

PDFService pdfService = new PDFService();
pdfService.CreatePDF(filePath, articulos);

Console.WriteLine("PDF creado exitosamente en: " + filePath);
    
