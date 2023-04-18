using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tp2SimulacionFINAL
{
    public  class GeneradorTablaFrecuenciasHelper
    {

        public static void GenerarTablaFrecuencias(double media,double desviacion,ComboBox comboBoxDistribucion,DataGridView dataGrid,double[] muestraGenerada, int numIntervalos) {
            // Calcular la amplitud del intervalo (Tamaño intervalo)
            double amplitud = ((muestraGenerada.Max() - muestraGenerada.Min()) / numIntervalos) + 0.01;

            List<dynamic> tabla = new List<dynamic>();

            // Calcular la distribución de frecuencias
            for (int i = 0; i < numIntervalos; i++)
            {
                double desde = Math.Round(muestraGenerada.Min() + (i * amplitud),4);
                double hasta = Math.Round(muestraGenerada.Min() + ((i + 1) * amplitud),4);
                int fo = 0;

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
                        fe = (double)muestraGenerada.Length / numIntervalos; // Calcular la frecuencia esperada (FE) [UNIFORME]
                        break;
                    case "2":
                        fe = (double) muestraGenerada.Length * (1 - Math.Exp(-(1/media) * hasta)) - muestraGenerada.Length * (1 - Math.Exp(-1/media * desde)); // Calcular la frecuencia esperada (FE) [EXP NEGATIVA]
                        break;
                    case "3":
                        fe = calcularFrecuenciaEsperadaNormal(media, desviacion , desde, hasta, muestraGenerada.Length);// Calcular la frecuencia esperada (FE) [NORMAL]
                        break;
                }


                tabla.Add(new { Intervalo = $"{desde} - {hasta}", FO = fo, FE = Math.Round(fe,4) });
            }

            dataGrid.DataSource = tabla;
        }


        public static double calcularFrecuenciaEsperadaNormal(double media,double desviacion,double desde, double hasta, int tamanioMuestra)
        {
            double marcaClase = (desde + hasta) / 2;

            return calcularDensidad(media,desviacion,marcaClase) * (hasta - desde) * tamanioMuestra;
        }

        public static double calcularDensidad(double media, double desviacion,double x)
        {
            var p1 = 1 / (desviacion * (Math.Sqrt(2 * Math.PI)));
            var p2 = Math.Pow(((x - media) / desviacion), 2);
            var p3 = -0.5 * p2;
            double p4 = Math.Pow(Math.E, p3);

            return p1 * p4;

        }






    }
}
