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
        public void CreatePDF(string filePath, List<Producto> productos)
        {
            // Crear un nuevo documento PDF
            PdfDocument pdf = new PdfDocument();
            PdfPage page = pdf.AddPage();

            // Crear un objeto de dibujo para la página
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 8);
            XFont fontBold = new XFont("Verdana", 10);

            // Definir la posición inicial
            double x = 25;
            double y = 25;
            double tableWidth = page.Width - 50;
            double rowHeight = 20;

            // Dibujar encabezados de la tabla
            gfx.DrawString("Codigo", fontBold, XBrushes.Black, x, y);
            gfx.DrawString("Nombre", fontBold, XBrushes.Black, x + 85, y);
            gfx.DrawString("PVP", fontBold, XBrushes.Black, x + 255, y);
            gfx.DrawString("Cantidad", fontBold, XBrushes.Black, x + 315, y);
            gfx.DrawString("Vigente", fontBold, XBrushes.Black, x + 365, y);
            y += rowHeight;

            // Dibujar líneas de la tabla
            gfx.DrawLine(XPens.Black, x, y, x + tableWidth, y);
            y += 15; // Espacio entre encabezados y líneas

            // Dibujar cada producto en la tabla
            foreach (var producto in productos)
            {
                gfx.DrawString(producto.Codigo, font, XBrushes.Black, x, y);
                gfx.DrawString(producto.Nombre, font, XBrushes.Black, x + 85, y);
                gfx.DrawString(producto.PrecioUnitario.ToString("C"), font, XBrushes.Black, x + 255, y);
                gfx.DrawString(producto.Cantidad.ToString("F2"), font, XBrushes.Black, x + 315, y);
                gfx.DrawString(producto.Vigente.ToString(), font, XBrushes.Black, x + 365, y);

                y += rowHeight + 100;

                // Dibujar líneas horizontales entre filas
                gfx.DrawLine(XPens.Black, x, y, x + tableWidth, y);
                y += 10; // Espacio entre filas
            }

            // Guardar el PDF
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                pdf.Save(fs);
            }
        }
    }
}
