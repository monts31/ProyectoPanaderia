using ClosedXML.Excel;
using ProyectoPanaderia.Backend;
using ProyectoPanaderia.POJO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoPanaderia
{
    public partial class frmReporteSencillo : Form
    {
        clsProductosConsultas productosConsultas = new clsProductosConsultas();
        clsAuditorias auditorias = new clsAuditorias();
        clsEmpleados empleadoActual = new clsEmpleados();
        public frmReporteSencillo()
        {
            InitializeComponent();
        }

        public frmReporteSencillo(clsEmpleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
        }

        
        /// solo las fechas indicadas del año actual pueden ser seleccionadas
        private void frmReporteSencillo_Load(object sender, EventArgs e)
        {
            productosConsultas.cargarProductoLista(checkedListBox1);
            int añoActual = DateTime.Now.Year;

            dtpInicio.MinDate = new DateTime(añoActual, 1, 1);
            dtpInicio.MaxDate = new DateTime(añoActual, 12, 31);

            dtpFin.MinDate = dtpInicio.MinDate;
            dtpFin.MaxDate = dtpInicio.MaxDate;
        }

        /// este metodo genera el comparativo entre dos meses seleccionados y los muestra en una grafica de barras
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<int> productosSeleccionados = new List<int>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                ProductoItem p = (ProductoItem)item;
                productosSeleccionados.Add(p.IdProducto);
            }
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un producto.");
                return;
            }
            DateTime inicioMes1 = new DateTime(dtpMes1.Value.Year, dtpMes1.Value.Month, 1);
            DateTime finMes1 = inicioMes1.AddMonths(1).AddSeconds(-1);

            DateTime inicioMes2 = new DateTime(dtpMes2.Value.Year, dtpMes2.Value.Month, 1);
            DateTime finMes2 = inicioMes2.AddMonths(1).AddSeconds(-1);


            DataTable dt = new clsAuditorias().ObtenerDatosComparativo(productosSeleccionados, inicioMes1, finMes1, inicioMes2, finMes2);
            foreach (DataRow fila in dt.Rows)
            {
                MessageBox.Show($"{fila["nombre"]}: Mes1={fila["ventas_mes_1"]}, Mes2={fila["ventas_mes_2"]}");
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar.");
                return;
            }


            ///mostrar en pantalla la grafica generada
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Configuración del Área del Gráfico
            ChartArea area = new ChartArea("Area");
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.Enabled = false; 
            area.AxisY.LabelStyle.Format = "C0";
            area.AxisY.Minimum = 0;              
            chart1.ChartAreas.Add(area);

            
            Series s1 = new Series("Mes 1")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "Area",
                IsXValueIndexed = false,
                XValueType = ChartValueType.String, 
              
            };
            Series s2 = new Series("Mes 2")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "Area",
                IsXValueIndexed = false,
                XValueType = ChartValueType.String, 
               
            };


            s1["DrawSideBySide"] = "True";
            s2["DrawSideBySide"] = "True";
            foreach (DataRow fila in dt.Rows)
            {
                string nombre = fila["nombre"].ToString();
                double v1 = Convert.ToDouble(fila["ventas_mes_1"]);
                double v2 = Convert.ToDouble(fila["ventas_mes_2"]);

                s1.Points.AddXY(nombre, v1);
                s2.Points.AddXY(nombre, v2);
            }
            chart1.Series.Add(s1);
            chart1.Series.Add(s2);
            chart1.AlignDataPointsByAxisLabel();

            chart1.Titles.Clear();
            chart1.Titles.Add("Comparativo de Ventas entre Meses");


            //  Guardar archivo
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xlsx)|*.xlsx";
            save.FileName = "ReporteComparativo.xlsx";

            if (save.ShowDialog() != DialogResult.OK)
                return;

            //  Exportar
            auditorias.ExportarComparativoMesesAExcel(
                inicioMes1, finMes1,
                inicioMes2, finMes2,
                productosSeleccionados,
                save.FileName
            );

            MessageBox.Show("Reporte generado correctamente.");
        }

       
        /// este metodo genera el reporte entre dos fechas seleccionadas y las muestra en el datagridview
        private void btnFechas_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = auditorias.reporte(dtpInicio.Value.Date, dtpFin.Value.Date);
            ExportarReporte(dtpInicio.Value.Date, dtpFin.Value.Date);
        }

        //este metodo exporta el reporte a excel usando closedxml libreria y ademas guarda el archivo en la ruta que el usuario elija
        // es el reporte de las fechas de inicio y fin seleccionadas
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (empleadoActual.rol == "Administrador")
            {
                frmMenuAdmin adminForm = new frmMenuAdmin(empleadoActual);
                this.Hide();
                adminForm.ShowDialog();
                this.Close();
            }
            else if (empleadoActual.rol == "Empleado")
            {
                frmMenuEmpleados empleadosform = new frmMenuEmpleados(empleadoActual);
                this.Hide();
                empleadosform.ShowDialog();
                this.Close();
            }
        }
    }
}
