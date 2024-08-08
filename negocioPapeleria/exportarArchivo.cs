using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;

namespace negocioPapeleria
{
    internal class exportarArchivo
    {


        public void ExportarPdf(DataGridView dataGridView, string nombre, string ruta, string mensaje, string numeroProductos, string fecha, string mensajeFinal)
        {
            try
            {

                // Crear un documento PDF
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Path.Combine(ruta, nombre + " " + fecha + ".pdf"), FileMode.Create));
                doc.Open();

                // Agregar línea de "Papelería Elenita's"
                Paragraph header = new Paragraph("Papelería Elenita's", FontFactory.GetFont(FontFactory.HELVETICA, 24, Font.BOLD));
                doc.Add(header);

                // Agregar mensaje personalizado
                Paragraph message = new Paragraph(mensaje, FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.NORMAL));
                doc.Add(message);

                // Agregar número de productos
                Paragraph products = new Paragraph(numeroProductos, FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.NORMAL));
                doc.Add(products);

                // Agregar fecha de hoy
                Paragraph date = new Paragraph("Fecha: " + fecha + "\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.NORMAL));
                doc.Add(date);

                // Crear una tabla para los datos del DataGridView
                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);
                table.WidthPercentage = 100;

                // Agregar las cabeceras de columna al PDF
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                // Agregar los datos de las filas al PDF
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value.ToString());
                    }
                }

                // Agregar la tabla al documento
                doc.Add(table);

                // Agregar datos adicionales al final
                Paragraph final = new Paragraph("\n" + mensajeFinal, FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.NORMAL));
                doc.Add(final);

                // Cerrar el documento
                doc.Close();

                MessageBox.Show("El archivo PDF se ha creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportarExcel(DataGridView dataGridView, string nombre, string ruta, string mensaje, string numeroProductos, string fecha, string mensajeTotal)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Crear un nuevo archivo de Excel
                var fileInfo = new FileInfo(Path.Combine(ruta, nombre + " " + fecha + ".xlsx"));
                using (var package = new ExcelPackage(fileInfo))
                {
                    // Añadir una nueva hoja al archivo Excel
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Datos");

                    // Escribir "Papelería Elenita's"
                    worksheet.Cells["A1"].Value = "Papelería Elenita's";

                    // Escribir el mensaje personalizado
                    worksheet.Cells["A2"].Value = mensaje;

                    // Escribir el número de productos
                    worksheet.Cells["A3"].Value = numeroProductos;

                    // Escribir la fecha
                    worksheet.Cells["A4"].Value = "Fecha: " + fecha;

                    // Escribir la fecha
                    worksheet.Cells["B4"].Value = mensajeTotal;

                    // Escribir los datos del DataGridView
                    int rowIndex = 5; // Comenzar a escribir desde la fila 5
                    int colIndex = 1; // Comenzar a escribir desde la columna 1
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        worksheet.Cells[rowIndex, colIndex].Value = column.HeaderText;
                        colIndex++;
                    }

                    rowIndex++;
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        colIndex = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            worksheet.Cells[rowIndex, colIndex].Value = cell.Value;
                            colIndex++;
                        }
                        rowIndex++;
                    }

                    // Ajustar automáticamente las columnas al contenido
                    worksheet.Cells.AutoFitColumns();

                    // Guardar el archivo Excel
                    package.Save();
                }

                MessageBox.Show("El archivo Excel se ha creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
