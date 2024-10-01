using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.UniversalAccessibility.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System.Drawing;       // Para trabajar con imágenes
using System.Drawing.Imaging; // Para trabajar con formatos de imagen

namespace CAP001_CreacionDocumentoPDF
{
    public class PDFService
    {
        public void CreatePDF(string filePath, List<Articulo> productos)
        {
            // Crear un nuevo documento PDF
            PdfDocument pdf = new PdfDocument();

            XGraphics gfx = null;
            PdfPage page = null;

            XFont font = new XFont("Verdana", 8);
            XFont fontBold = new XFont("Verdana", 10);

            // Definir las dimensiones iniciales de la tabla
            double x = 25;
            double y = 25;
            double tableWidth = 0;
            double rowHeight = 20;

            // Definir la cantidad de espacio disponible por página (descontando márgenes)
            double pageHeight = 0;
            double availableHeight = 0;
            int maxRowsPerPage = 0;

            int currentRow = 0;

            // Función para crear una nueva página y reiniciar el objeto de dibujo
            void AddNewPage()
            {
                page = pdf.AddPage();
                gfx = XGraphics.FromPdfPage(page);
                tableWidth = page.Width - 50;
                pageHeight = page.Height;
                availableHeight = pageHeight - 50; // margen superior e inferior
                //maxRowsPerPage = (int)(availableHeight / rowHeight); // número máximo de filas por página
                maxRowsPerPage = (6); // número máximo de filas por página
                y = 25; // Reiniciar la posición vertical para la nueva página

                // Dibujar encabezados de la tabla en la nueva página
                gfx.DrawString("Codigo", fontBold, XBrushes.DarkRed, x, y);
                gfx.DrawString("Nombre", fontBold, XBrushes.DarkRed, x + 85, y);
                gfx.DrawString("PVP", fontBold, XBrushes.DarkRed, x + 300, y);
                gfx.DrawString("Existencia", fontBold, XBrushes.DarkRed, x + 360, y);
                gfx.DrawString("Vigente", fontBold, XBrushes.DarkRed, x + 415, y);
                gfx.DrawString("Imagen", fontBold, XBrushes.DarkRed, x + 460, y);

                y += rowHeight;

                // Dibujar la línea debajo del encabezado
                gfx.DrawLine(XPens.Gray, x, y, x + tableWidth, y);
                y += 15; // Espacio entre encabezados y líneas
            }

            // Dibujar cada producto en la tabla
            foreach (var producto in productos)
            {
                // Comprobar si es la primera página o si hemos alcanzado el número máximo de filas por página
                if (page == null || currentRow >= maxRowsPerPage)
                {
                    AddNewPage(); // Solo se llama cuando realmente es necesario añadir una nueva página
                    currentRow = 0; // Reiniciar el contador de filas para la nueva página
                }

                // Dibujar el contenido de la fila
                gfx.DrawString(producto.Codigo, font, XBrushes.Black, x, y);
                // Asegúrate de que el nombre del producto no exceda los 42 caracteres
                string nombreCortado = producto.Nombre.Length > 42 ? producto.Nombre.Substring(0, 42) : producto.Nombre;
                gfx.DrawString(nombreCortado, font, XBrushes.Black, x + 85, y);
                gfx.DrawString(producto.Pvp.ToString("C"), font, XBrushes.Black, x + 300, y);
                gfx.DrawString(producto.Existencia.ToString("F2"), font, XBrushes.Black, x + 360, y);
                gfx.DrawString(String.Concat(producto.Ubicacion.ToString(), " - ", producto.Vigente.ToString()), font, XBrushes.Black, x + 415, y);

                // Si el producto tiene una imagen
                if (producto.Imagen != null)
                {
                    using (var ms = new MemoryStream(producto.Imagen))
                    {
                        // Reiniciar la posición del MemoryStream
                        ms.Position = 0;

                        // Cargar la imagen usando ImageSharp
                        var image = SixLabors.ImageSharp.Image.Load<Rgba32>(ms);

                        // Guardar la imagen en un nuevo MemoryStream en formato PNG o JPEG
                        using (var outputStream = new MemoryStream())
                        {
                            image.SaveAsPng(outputStream); // Cambia a SaveAsJpeg si tienes imágenes JPEG
                            outputStream.Position = 0; // Reiniciar la posición para leer desde el inicio

                            // Crear la imagen a partir del MemoryStream
                            using (var img = XImage.FromStream(outputStream))
                            {
                                // Dibujar la imagen en el PDF
                                gfx.DrawImage(img, x + 460, y, 100, 100); // Ajusta la posición y tamaño según sea necesario
                            }
                        }
                    }
                }



                y += rowHeight + 100;

                // Dibujar una línea horizontal debajo de la fila
                gfx.DrawLine(XPens.Gray, x, y - 15, x + tableWidth, y - 15);
                y += 5; // Espacio entre filas
                currentRow++;
            }

            // Guardar el PDF
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                pdf.Save(fs);
            }
        }

    }


}