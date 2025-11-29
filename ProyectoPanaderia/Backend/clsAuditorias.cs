using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoPanaderia.Backend
{
    public class clsAuditorias
    {
        public clsAuditorias() { }

        public System.Data.DataTable obtenerAuditoria()
        {
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();
                string query = "SELECT * FROM auditorias";
                MySqlCommand comando = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                System.Data.DataTable tablaAuditorias = new System.Data.DataTable();
                adapter.Fill(tablaAuditorias);
                return tablaAuditorias;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable reporte(DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();
            string query = "select p.id_producto, p.nombre, sum(d.cantidad) as cantidad, sum(d.precio* d.cantidad) as monto\r\nfrom detalles d inner join productos p on d.id_Producto = p.id_producto\r\ninner join ordenes o on o.id_Orden = d.id_Orden where date(o.fecha) between @fechaInicio and @fechaFin\r\ngroup by p.id_producto, p.nombre order by cantidad desc;";
            MySqlConnection cn = Conexion.conexion();
            try
            {
                cn.Open();
                MySqlCommand comando = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                comando.Parameters.AddWithValue("@fechaInicio", inicio);
                comando.Parameters.AddWithValue("@fechaFin", fin);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el reporte: " + ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }

        public void ExportarComparativoMesesAExcel(DateTime inicioMes1, DateTime finMes1, DateTime inicioMes2, DateTime finMes2,
        IEnumerable<int> productosSeleccionados,string rutaArchivo)
        {
            // ---- VALIDACIONES ----
            if (productosSeleccionados == null)
                throw new Exception("No se recibieron productos.");

            if (!productosSeleccionados.GetEnumerator().MoveNext())
                throw new Exception("Seleccione al menos un producto.");

            // ---- CONSULTA ----
            string ids = string.Join(",", productosSeleccionados);

            string query = $@"
            select p.id_producto, p.nombre, p.precio, 
            sum(case when month(o.fecha)=@mes1 and year(o.fecha)=@anio1 then d.precio* d.cantidad else 0 end) as ventas_mes_1,
            sum(case when month(o.fecha)=@mes2 and year(o.fecha)=@anio2 then d.precio* d.cantidad else 0 end) as ventas_mes_2
            from productos p left join detalles d on p.id_producto=d.id_producto
            left join ordenes o on d.id_orden=o.id_orden where p.id_producto in ({ids})
            group by p.id_producto, p.nombre, p.precio order by ventas_mes_1 desc, ventas_mes_2 desc";
            MySqlConnection cn = Conexion.conexion();

            DataTable dt = new DataTable();

            try { 
                cn.Open();
                MySqlCommand command = new MySqlCommand(query, cn);
                command.Parameters.AddWithValue("@mes1", inicioMes1.Month);
                command.Parameters.AddWithValue("@anio1", inicioMes1.Year);
                command.Parameters.AddWithValue("@mes2", inicioMes2.Month);
                command.Parameters.AddWithValue("@anio2", inicioMes2.Year);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                    throw new Exception("No hay datos para generar el reporte.");
                // ---- CREAR GRAFICA EN MEMORIA ----
                MemoryStream imagenGrafica = new MemoryStream();

                using (var chart = new Chart())
                {
                    chart.Width = 1200;
                    chart.Height = 600;

                    ChartArea area = new ChartArea("Area");
                    area.AxisX.Interval = 1;
                    area.AxisX.LabelStyle.Angle = -45;
                    area.AxisY.LabelStyle.Format = "C0";
                    area.AxisY.Minimum = 0;
                    chart.ChartAreas.Add(area);

                    Series s1 = new Series("Mes 1")
                    {
                        ChartType = SeriesChartType.Column,
                        ChartArea = "Area",
                        IsXValueIndexed = false,
                        XValueType = ChartValueType.String, // <--- ¡CORRECCIÓN CLAVE! Trata X como categoría de texto.
                                                            //Color = Color.DarkOrange
                    };
                    Series s2 = new Series("Mes 2")
                    {
                        ChartType = SeriesChartType.Column,
                        ChartArea = "Area",
                        IsXValueIndexed = false,
                        XValueType = ChartValueType.String, // <--- ¡CORRECCIÓN CLAVE!
                                                            //Color = Color.DarkGreen
                    };

                    s1["DrawSideBySide"] = "True";
                    s2["DrawSideBySide"] = "True";

                    foreach (DataRow r in dt.Rows)
                    {
                        string nombre = r["nombre"].ToString();
                        double v1 = Convert.ToDouble(r["ventas_mes_1"]);
                        double v2 = Convert.ToDouble(r["ventas_mes_2"]);

                        s1.Points.AddXY(nombre, v1);
                        s2.Points.AddXY(nombre, v2);
                    }

                    chart.Series.Add(s1);
                    chart.Series.Add(s2);
                    chart.AlignDataPointsByAxisLabel();
                    chart.Titles.Add("Comparativo de Ventas");

                    chart.SaveImage(imagenGrafica, ChartImageFormat.Png);
                }

                imagenGrafica.Position = 0;

                // ---- EXPORTAR EXCEL ----
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Reporte");

                    // Título
                    ws.Cell(1, 1).Value = "Reporte Comparativo de Ventas";
                    ws.Cell(1, 1).Style.Font.SetBold();

                    ws.Cell(2, 1).Value = $"Periodo 1: {inicioMes1:yyyy-MM-dd} - {finMes1:yyyy-MM-dd}";
                    ws.Cell(3, 1).Value = $"Periodo 2: {inicioMes2:yyyy-MM-dd} - {finMes2:yyyy-MM-dd}";

                    // Tabla desde fila 5
                    var tabla = ws.Cell(5, 1).InsertTable(dt, "TablaVentas", true);
                    tabla.Theme = XLTableTheme.TableStyleMedium9;

                    ws.Columns().AdjustToContents();

                    // Insertar gráfica como imagen
                    ws.AddPicture(imagenGrafica)
                      .MoveTo(ws.Cell(5, dt.Columns.Count + 3))
                      .Scale(0.7);

                    wb.SaveAs(rutaArchivo);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el reporte: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            
        }

        //para mostrar en el chart las graficas en el formulario
        public DataTable ObtenerDatosComparativo(
    IEnumerable<int> productosSeleccionados,
    DateTime inicioMes1, DateTime finMes1,
    DateTime inicioMes2, DateTime finMes2)
        {
            if (productosSeleccionados == null || !productosSeleccionados.Any())
                throw new Exception("No se recibieron productos.");

            string ids = string.Join(",", productosSeleccionados);

            string query = $@"
        SELECT 
            p.id_producto, 
            p.nombre, 
            p.precio,
            SUM(CASE WHEN MONTH(o.fecha) = @mes1 AND YEAR(o.fecha) = @anio1 THEN d.precio * d.cantidad ELSE 0 END) AS ventas_mes_1,
            SUM(CASE WHEN MONTH(o.fecha) = @mes2 AND YEAR(o.fecha) = @anio2 THEN d.precio * d.cantidad ELSE 0 END) AS ventas_mes_2
        FROM productos p
        LEFT JOIN detalles d ON p.id_producto = d.id_producto
        LEFT JOIN ordenes o ON d.id_orden = o.id_orden
        WHERE p.id_producto IN ({ids})
        GROUP BY p.id_producto, p.nombre, p.precio
        ORDER BY ventas_mes_1 DESC, ventas_mes_2 DESC;
    ";

            DataTable dt = new DataTable();

            using (MySqlConnection cn = Conexion.conexion())
            using (MySqlCommand cmd = new MySqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@mes1", inicioMes1.Month);
                cmd.Parameters.AddWithValue("@anio1", inicioMes1.Year);
                cmd.Parameters.AddWithValue("@mes2", inicioMes2.Month);
                cmd.Parameters.AddWithValue("@anio2", inicioMes2.Year);

                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }


    }
}