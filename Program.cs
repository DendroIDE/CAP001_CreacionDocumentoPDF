using CAP001_CreacionDocumentoPDF;

string filePath = "c:\\temp\\ListadoArticulos.pdf";

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
    