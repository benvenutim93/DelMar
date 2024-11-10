/*using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace DescartablesDelMar.Utiles
{
    public class PdfUtils
    {
        #region Declaration

        private int Columns;
        private List<PresupuestoItem> ObjectList;

        #endregion

        public void CreatePdf(string pathArchivo, string title, List<PresupuestoItem> listaItems, PresupuestoTotalItem listaFooter = null)
        {
            Columns = 9;
            ObjectList = listaItems;

            using (FileStream stream = new FileStream(pathArchivo, FileMode.Create))
            {
                // Crear el PdfDocument (en lugar de PdfWriter + Document)
                PdfWriter writer = new PdfWriter(stream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf, PageSize.A4);

                // Insertar encabezado
                InsertDatosLocal(document);

                // Crear título
                CreateTitle(document, title);

                // Crear cabeceras
                CreateCabeceras(document);

                // Crear cuerpo
                CreateBody(document);

                // Crear pie de página
                CreateFooter(document, listaFooter);

                // Cerrar el documento
                document.Close();
            }
        }

        private void InsertDatosLocal(Document document)
        {
            var font = PdfFontFactory.CreateFont("Tahoma");
            Paragraph p = new Paragraph("Descartables del Mar")
                .SetFont(font)
                .SetFontSize(8)
                .SetTextAlignment(TextAlignment.LEFT);
            document.Add(p);

            p = new Paragraph("Acapulco 649 / 460-2434")
                .SetFont(font)
                .SetFontSize(8)
                .SetTextAlignment(TextAlignment.LEFT);
            document.Add(p);
        }

        private void CreateTitle(Document document, string title)
        {
            var font = PdfFontFactory.CreateFont("Tahoma");
            Paragraph p = new Paragraph(title)
                .SetFont(font)
                .SetFontSize(10)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBold();
            document.Add(p);
        }

        private void CreateCabeceras(Document document)
        {
            var table = new Table(Columns);
            table.AddCell(CreateCell("Codigo", TextAlignment.CENTER, new DeviceGray(0.75f)));
            table.AddCell(CreateCell("Nombre", TextAlignment.CENTER, new DeviceGray(0.75f), 2));
            table.AddCell(CreateCell("Contenido", TextAlignment.CENTER, new DeviceGray(0.75f)));
            table.AddCell(CreateCell("Cantidad", TextAlignment.CENTER, new DeviceGray(0.75f)));
            table.AddCell(CreateCell("Precio Unitario", TextAlignment.CENTER, new DeviceGray(0.75f), 2));
            table.AddCell(CreateCell("Total", TextAlignment.CENTER, new DeviceGray(0.75f), 2));

            document.Add(table);
        }

        private void CreateBody(Document document)
        {
            var table = new Table(Columns);

            foreach (var o in ObjectList)
            {
                table.AddCell(CreateCell(o.Codigo.ToString(), TextAlignment.CENTER, new DeviceGray(1f)));
                table.AddCell(CreateCell(o.Nombre.ToString(), TextAlignment.CENTER, new DeviceGray(1f), 2));
                table.AddCell(CreateCell(o.Contenido.ToString(), TextAlignment.CENTER, new DeviceGray(1f)));
                table.AddCell(CreateCell(o.Cantidad.ToString(), TextAlignment.CENTER, new DeviceGray(1f)));
                table.AddCell(CreateCell(o.PrecioVenta.ToString(), TextAlignment.RIGHT, new DeviceGray(1f), 2));
                table.AddCell(CreateCell(o.PrecioTotal.ToString(), TextAlignment.RIGHT, new DeviceGray(1f), 2));
            }

            document.Add(table);
        }

        private void CreateFooter(Document document, PresupuestoTotalItem footer)
        {
            var table = new Table(Columns);
            table.AddCell(CreateCell("Cantidad Items", TextAlignment.CENTER, new DeviceGray(0.75f), 2));
            table.AddCell(CreateCell(footer.CantidadArticulos.ToString(), TextAlignment.RIGHT, new DeviceGray(1f), 7));
            table.AddCell(CreateCell("Total: ", TextAlignment.CENTER, new DeviceGray(0.75f), 2));
            table.AddCell(CreateCell($"{footer.TotalFormateado}", TextAlignment.RIGHT, new DeviceGray(1f), 7));

            document.Add(table);
        }

        private Cell CreateCell(string contenido, TextAlignment alignment, Color backgroundColor, int colspan = 1)
        {
            var font = PdfFontFactory.CreateFont("Tahoma");
            var cell = new Cell().Add(new Paragraph(contenido).SetFont(font).SetFontSize(8))
                                 .SetBackgroundColor(backgroundColor)
                                 .SetTextAlignment(alignment)
                                 .SetVerticalAlignment(VerticalAlignment.MIDDLE);
            //.SetColspan(colspan);
            return cell;
        }
    }
}
*/