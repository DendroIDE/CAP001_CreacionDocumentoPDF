using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                availableHeight = pageHeight - 100; // margen superior e inferior
                maxRowsPerPage = (int)(availableHeight / rowHeight); // número máximo de filas por página
                y = 25; // Reiniciar la posición vertical para la nueva página

                // Dibujar encabezados de la tabla en la nueva página
                gfx.DrawString("Codigo", fontBold, XBrushes.Black, x, y);
                gfx.DrawString("Nombre", fontBold, XBrushes.Black, x + 85, y);
                gfx.DrawString("PVP", fontBold, XBrushes.Black, x + 255, y);
                gfx.DrawString("Existencia", fontBold, XBrushes.Black, x + 315, y);
                gfx.DrawString("Vigente", fontBold, XBrushes.Black, x + 365, y);
                y += rowHeight;

                // Dibujar la línea debajo del encabezado
                gfx.DrawLine(XPens.Black, x, y, x + tableWidth, y);
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
                gfx.DrawString(producto.Nombre, font, XBrushes.Black, x + 85, y);
                gfx.DrawString(producto.Pvp.ToString("C"), font, XBrushes.Black, x + 255, y);
                gfx.DrawString(producto.Existencia.ToString("F2"), font, XBrushes.Black, x + 315, y);
                gfx.DrawString(producto.Vigente.ToString(), font, XBrushes.Black, x + 365, y);
                y += rowHeight + 100;

                // Dibujar una línea horizontal debajo de la fila
                gfx.DrawLine(XPens.Black, x, y, x + tableWidth, y);
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