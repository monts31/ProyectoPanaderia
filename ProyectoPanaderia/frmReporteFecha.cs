using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ProyectoPanaderia
{
    public partial class frmReporteFecha : Form
    {
        public frmReporteFecha()
        {
            InitializeComponent();
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpInicio.Value > dtpFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (dtpFin.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de fin no puede ser mayor a la fecha actual.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpInicio.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha actual.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ExportarReporte(dtpInicio.Value.Date, dtpFin.Value.Date);
        }

        private void frmReporteFecha_Load(object sender, EventArgs e)
        {
            int añoActual = DateTime.Now.Year;

            dtpInicio.MinDate = new DateTime(añoActual, 1, 1);
            dtpInicio.MaxDate = new DateTime(añoActual, 12, 31);

            dtpFin.MinDate = dtpInicio.MinDate;
            dtpFin.MaxDate = dtpInicio.MaxDate;
        }

        public void ExportarReporte(DateTime inicio, DateTime fin)
        {
            try
            {
                DataTable datos = new Backend.clsAuditorias().reporte(inicio, fin);

                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos en el período seleccionado.");
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel (*.xlsx)|*.xlsx";
                save.FileName = "ReporteVentas.xlsx";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook libro = new XLWorkbook())
                    {
                        // Esto añade la DataTable y la formatea automáticamente como una tabla de Excel.
                        // La variable hoja ahora es donde se guardaran los datos ya como tabla.
                        var hoja = libro.Worksheets.Add(datos, "Reporte");
                        // ClosedXML asigna el DataTable como una tabla por defecto,y esa tabla ya está en hoja.Tables.
                        // La forma más directa de aplicar el tema a la tabla que ClosedXML crea
                        // al pasar un DataTable es simplemente:
                        hoja.Table("Table1").Theme = XLTableTheme.TableStyleMedium9;
                        // ClosedXML nombra la primera tabla "Table1" si no se especifica.
                 
                        libro.SaveAs(save.FileName);
                    }

                    MessageBox.Show("Reporte generado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }

    }
}
