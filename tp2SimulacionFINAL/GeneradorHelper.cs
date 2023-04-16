using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tp2SimulacionFINAL
{
    public class GeneradorHelper
    {

        public static double[] GenerarDistUniforme(int n, int a, int b) 
        {
            var variablesGeneradas = new double[n];
            var rnd = new Random();
            for (int i = 0; i < n; i++) {
                variablesGeneradas[i] = Math.Round(a + rnd.NextDouble() * (b - a), 4);
            }

            return variablesGeneradas;
        
        }

        public static double[] GenerarDistExpNegativa(int n, int media) {

            var variablesGeneradas = new double[n];
            var rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                variablesGeneradas[i] = Math.Round(-media*Math.Log(1-rnd.NextDouble()), 4);
            }

            return variablesGeneradas;
        }

        public static double[] GenerarDistNormal(int n, double media, double desviacion)
        {
            
            var variablesGeneradas = new double[n];
            var rnd = new Random();

            for (int i = 0; i < n; i += 2)
            {
                double u1 = rnd.NextDouble();
                double u2 = rnd.NextDouble();

                double n1 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);
                double n2 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);

                variablesGeneradas[i] = n1 * desviacion + media;
                variablesGeneradas[i + 1] = n2 * desviacion + media;
            }

            return variablesGeneradas;
        }















    }
}
