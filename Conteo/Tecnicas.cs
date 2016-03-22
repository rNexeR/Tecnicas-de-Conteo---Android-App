/*
    Codigo fuente obtenido de https://github.com/Raimmaster/DiscreteTechniques @raimmaster, Modificado para su uso en este proyecto.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tecnicas
{
    public class TecnicasConteo
    {
        private static MathTools mt = new MathTools();

        public TecnicasConteo()
        {
            mt = new MathTools();
        }

        public static double permutacionSinRepeticion(double n)
        {
            return mt.factorial(n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Cantidad de elementos que contiene</param>
        /// <param name="subconjuntos">Una lista que contiene subconjuntos cuya suma es n</param>
        /// <returns></returns>
        public static double permutacionConRepeticion(double n, List<double> subconjuntos)
        {
            double denominador = 1;

            foreach (double m in subconjuntos)
            {
                denominador *= mt.factorial(m);
                Console.WriteLine(m);
            }

            if (denominador == 0)
                return 1;

            return mt.factorial(n) / denominador;
        }

        public static double variacionSinRepeticion(double n, double m)
        {
            double divisor = mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public static double variacionConRepeticion(double n, double m)
        {
            return (double)Math.Pow(n, m);
        }

        public static double combinacionSinRepeticion(double n, double m)
        {
            double divisor = mt.factorial(m) * mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public static double combinacionConRepeticion(double n, double m)
        {
            double numerador = mt.factorial(m + n - 1);
            double denominador = mt.factorial(n) * mt.factorial(m - 1);

            Console.WriteLine("Num: " + numerador + " Dem: " + denominador);

            return numerador / denominador;
        }

        public static double permutacionCircular(double n)
        {
            return mt.factorial(n - 1);
        }

        public static double reglaMultiplicativa(List<double> subconjuntos)
        {
            double tot = 1;
            foreach (double n in subconjuntos)
            {
                tot *= n;
            }

            return tot;
        }

        public static double reglaAditiva(List<double> subconjuntos)
        {
            double tot = 0;
            foreach (double n in subconjuntos)
            {
                tot += n;
            }

            return tot;
        }
    }

    public class MathTools
    {
        public MathTools()
        {

        }

        public double factorial(double numero)
        {
            if (numero == 0)
                return 1;

            return numero * factorial(numero - 1);
        }


    }
}
