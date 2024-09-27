using CAP001_CreacionDocumentoPDF;

string filePath = "c:\\temp\\ListadoArticulos.pdf";

// Definir la cadena de conexión aquí
//string connectionString = "User Id=prd;Password=prd;Data Source=((DESCRIPTION =(ADDRESS_LIST=(ADDRESS =(PROTOCOL = TCP)(HOST = 192.168.1.12)(PORT = 1522)))(CONNECT_DATA =(SERVICE_NAME = mgk))))";
string connectionString = "User Id=prd;Password=prd;Data Source=//192.168.1.12:1522/mgk";

using (var oracleService = new OracleService(connectionString))
{
    // Llamar al método que ejecuta una consulta
    oracleService.GetProducts();
}

// Crear una lista de productos
List<Producto> productos = new List<Producto>
        {
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' },
            new Producto {Codigo = "01L.05AS.SAS", Nombre = "Producto 1", PrecioUnitario = 10.99m, Cantidad = 5, Vigente = 'S' }
        };

PDFService pdfService = new PDFService();
pdfService.CreatePDF(filePath, productos);

Console.WriteLine("PDF creado exitosamente en: " + filePath);
    