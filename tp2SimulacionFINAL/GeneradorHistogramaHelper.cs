using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace tp2SimulacionFINAL
{
    public class GeneradorHistogramaHelper
    {
        public static void GenerarHistograma(DataGridView tabla, Chart histograma)
        {
            // Obtén los datos del DataGridView
            var intervalos = tabla.Rows.Cast<DataGridViewRow>()
                                .Select(row => row.Cells["Intervalo"].Value.ToString()) // Reemplaza "Intervalo" con el nombre de la columna que contiene los intervalos en tu DataGridView
                                .ToArray();
            var fo = tabla.Rows.Cast<DataGridViewRow>()
                            .Select(row => Convert.ToInt32(row.Cells["FO"].Value)) // Reemplaza "FO" con el nombre de la columna que contiene las frecuencias observadas en tu DataGridView
                            .ToArray();
            var fe = tabla.Rows.Cast<DataGridViewRow>()
                            .Select(row => Convert.ToDouble(row.Cells["FE"].Value)) // Reemplaza "FE" con el nombre de la columna que contiene las frecuencias esperadas en tu DataGridView
                            .ToArray();

            // Configura el Chart control
            histograma.Series.Clear(); // Limpia cualquier serie existente
            histograma.ChartAreas[0].AxisX.Title = "Intervalos"; // Configura el título del eje X
            histograma.ChartAreas[0].AxisY.Title = "Frecuencia"; // Configura el título del eje Y

            // Crear la serie para FO
            Series serieFO = new Series("FO");
            serieFO.ChartType = SeriesChartType.Column;
            serieFO.Color = Color.Blue;

            // Crear la serie para FE
            Series serieFE = new Series("FE");
            serieFE.ChartType = SeriesChartType.Column;
            serieFE.Color = Color.Violet;


            // Agregar las series al gráfico
            histograma.Series.Add(serieFO);
            histograma.Series.Add(serieFE);

            // Configurar posición de las columnas en el eje X
            serieFO.SetCustomProperty("PointWidth", "0.4"); // Ancho de las columnas de FO
            serieFE.SetCustomProperty("PointWidth", "0.4"); // Ancho de las columnas de FE

            serieFO.SetCustomProperty("PointOffset", "-50"); // Desplazamiento de 50 píxeles hacia la izquierda

            serieFE.SetCustomProperty("PointOffset", "50"); // Desplazamiento de 50 píxeles hacia la derecha


            // Agrega los datos al Chart control como dos series de barras, una para FO y otra para FE
            for (int i = 0; i < intervalos.Length; i++)
            {
                string[] intervaloSplit = intervalos[i].Split('-'); // Dividir el intervalo en "desde" y "hasta"
                string desde = intervaloSplit[0].Trim(); // Obtener el "desde"
                string hasta = intervaloSplit[1].Trim(); // Obtener el "hasta"

                serieFE.Points.AddXY($"Intervalo {desde}-{hasta}", fe[i]);
                serieFO.Points.AddXY($"Intervalo {desde}-{hasta}", fo[i]);

                serieFO.Points[i].Label = fo[i].ToString();
                serieFE.Points[i].Label = fe[i].ToString();
            }

           

            histograma.ChartAreas[0].AxisX.Interval = 1; // Mostrar todas las etiquetas del eje X
            histograma.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotar etiquetas del eje X para una mejor legibilidad
            histograma.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false; // Ocultar última etiqueta del eje X para evitar solapamientos

            histograma.Update();

        }


    }
}

    

    
