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
        public void CreatePDF(string filePath)
        {
            // Crear un nuevo documento PDF
            PdfDocument pdf = new PdfDocument();
            PdfPage page = pdf.AddPage();

            // Crear un objeto de dibujo para la página
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Establecer fuente y tamaño
            XFont font = new XFont("Verdana", 20);

            // Dibujar texto en el PDF
            gfx.DrawString("Hola, este es un PDF creado con PdfSharp", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);

            // Guardar el PDF
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                pdf.Save(fs);
            }
        }
    }
}
