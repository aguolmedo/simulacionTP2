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
                            .Select(row => Convert.ToInt32(row.Cells["FE"].Value)) // Reemplaza "FE" con el nombre de la columna que contiene las frecuencias esperadas en tu DataGridView
                            .ToArray();

            // Configura el Chart control
            histograma.Series.Clear(); // Limpia cualquier serie existente
            histograma.ChartAreas[0].AxisX.Title = "Intervalos"; // Configura el título del eje X
            histograma.ChartAreas[0].AxisY.Title = "Frecuencia"; // Configura el título del eje Y

            // Colores para las barras de FO y FE
            Color colorFO = Color.Blue; // Color para FO
            Color colorFE = Color.Red; // Color para FE

            // Agrega los datos al Chart control como dos series de barras, una para FO y otra para FE
            for (int i = 0; i < intervalos.Length; i++)
            {
                string[] intervaloSplit = intervalos[i].Split('-'); // Dividir el intervalo en "desde" y "hasta"
                string desde = intervaloSplit[0].Trim(); // Obtener el "desde"
                string hasta = intervaloSplit[1].Trim(); // Obtener el "hasta"

                histograma.Series.Add($"Intervalo {desde}-{hasta}");
                histograma.Series[$"Intervalo {desde}-{hasta}"].ChartType = SeriesChartType.Column; // Tipo de gráfico de barras
                histograma.Series[$"Intervalo {desde}-{hasta}"].Color = Color.Blue; // Color de la columna de FO
                histograma.Series[$"Intervalo {desde}-{hasta}"].Points.AddXY($"FO", fo[i]); // Agrega el dato de FO a la serie
                histograma.Series[$"Intervalo {desde}-{hasta}"].Points.AddXY($"FE", fe[i]); // Agrega el dato de FE a la serie
                histograma.Series[$"Intervalo {desde}-{hasta}"].Points[0].Color = Color.Blue; // Color de la barra de FO
                histograma.Series[$"Intervalo {desde}-{hasta}"].Points[1].Color = Color.Red; // Color de la barra de FE
                histograma.Series[$"Intervalo {desde}-{hasta}"].Points[0].AxisLabel = ""; // Etiqueta vacía del eje X para FO
                histograma.Series[$"Intervalo {desde}-{hasta}"].Points[1].AxisLabel = ""; // Etiqueta vacía del eje X para FE
                histograma.Series[$"Intervalo {desde}-{hasta}"].IsVisibleInLegend = false; // Oculta la leyenda de la serie


            }


        }
    }
}

    

    
