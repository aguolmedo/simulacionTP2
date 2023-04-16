using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2SimulacionFINAL
{
    public  class GeneradorTablaFrecuenciasHelper
    {

        public static void GenerarTablaFrecuencias(ComboBox comboBoxDistribucion,DataGridView dataGrid,double[] muestraGenerada, int numIntervalos) {
            // Calcular la amplitud del intervalo
            double amplitud = ((muestraGenerada.Max() - muestraGenerada.Min()) / numIntervalos) + 0.01;

            // Crear una lista para almacenar los resultados
            List<dynamic> tabla = new List<dynamic>();

            // Calcular la distribución de frecuencias
            for (int i = 0; i < numIntervalos; i++)
            {
                double desde = Math.Round(muestraGenerada.Min() + (i * amplitud),4);
                double hasta = Math.Round(muestraGenerada.Min() + ((i + 1) * amplitud),4);
                int fo = 0;

                // Contar la frecuencia observada (FO)
                foreach (double valor in muestraGenerada)
                {
                    if (valor >= desde && valor <= hasta)
                    {
                        fo++;
                    }
                }

                double fe = 0;
                switch (comboBoxDistribucion.SelectedValue.ToString()) {

                    case "1":
                        fe = (double)muestraGenerada.Length / numIntervalos; // Calcular la frecuencia esperada (FE)
                        break;
                    case "2":
                        fe = (double)muestraGenerada.Length / numIntervalos; // Calcular la frecuencia esperada (FE)
                        break;
                    case "3":
                        fe = (double)muestraGenerada.Length / numIntervalos; // Calcular la frecuencia esperada (FE)
                        break;
                }


                // Agregar los resultados a la lista
                tabla.Add(new { Intervalo = $"{desde} - {hasta}", FO = fo, FE = fe });
            }

            // Asignar la lista como fuente de datos del DataGridView
            dataGrid.DataSource = tabla;
        }


    }
}
