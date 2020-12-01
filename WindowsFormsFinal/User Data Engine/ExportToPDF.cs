using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;

namespace WindowsFormsFinal
{
    public static class ExportToPDF
    {
        // lớp này xử lí việc in dữ liệu ra file PDF dựa trên thư viện iTextSharp
        public static void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document(PageSize.A5.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            BaseFont bf = BaseFont.CreateFont("Lora-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //Report Header
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bf, 24, 0, new BaseColor(34, 31, 31));

            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader, fntHead));
            document.Add(prgHeading);

            //Time
            Paragraph prgAuthor = new Paragraph();
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(bf, 11, 0, new BaseColor(34, 31, 31));
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\nDate : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.
                LineSeparator(0.0F, 100.0F, BaseColor.GRAY, Element.ALIGN_CENTER, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n"));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);

            //Table header
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.Phrase = new Phrase(dtblTable.Columns[i].ColumnName,
                    new iTextSharp.text.Font(bf, 11, 0, new BaseColor(255, 255, 186)));
                cell.BackgroundColor = new BaseColor(34, 31, 31);
                cell.HorizontalAlignment = Element.ALIGN_TOP;
                cell.PaddingLeft = 10;
                cell.PaddingTop = 5;
                cell.PaddingBottom = 5;
                cell.BorderColor = new BaseColor(34, 31, 31);
                cell.UseAscender = true;
                table.AddCell(cell);
            }

            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.Phrase = new Phrase(dtblTable.Rows[i][j].ToString(),
                    new iTextSharp.text.Font(bf, 10, 0, new BaseColor(34, 31, 31)));
                    cell.BackgroundColor = new BaseColor(255, 255, 255);
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    cell.PaddingRight = 10;
                    cell.PaddingTop = 5;
                    cell.PaddingBottom = 5;
                    cell.BorderColor = new BaseColor(34, 31, 31);
                    cell.UseAscender = true;
                    table.AddCell(cell);
                }
            }
            table.WidthPercentage = 100;
            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
