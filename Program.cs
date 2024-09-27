using CAP001_CreacionDocumentoPDF;

string filePath = "D:\\documento_pdfsharp.pdf";
PDFService pdfService = new PDFService();
pdfService.CreatePDF(filePath);

Console.WriteLine("PDF creado exitosamente en: " + filePath);