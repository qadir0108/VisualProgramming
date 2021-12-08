using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Data
{
    public class PDFGenerator
    {
        public void Generate(Order order)
        {
            string pdfFilePath = System.IO.Path.Combine(Environment.CurrentDirectory, $"{order.Id}.pdf");

            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter(pdfFilePath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Customer Order")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);
            document.Add(header);

            // Line separator
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            // Add paragraph1
            Paragraph paragraph1 = new Paragraph("Customer Name : " + order.CustomerName);
            document.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph("Total Bill : " + order.Bill);
            document.Add(paragraph2);

            document.Close();

            System.Diagnostics.Process.Start(pdfFilePath);

        }
    }
}
