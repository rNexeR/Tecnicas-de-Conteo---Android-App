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
using Android.Content.PM;
using Android.Text.Method;

namespace Conteo
{
    [Activity(Label = "Regla Multiplicativa", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Multiplicativa : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Multiplicativa);

            Button agregar = FindViewById<Button>(Resource.Id.m_Agregar);
            Button Calcular = FindViewById<Button>(Resource.Id.m_Calcular);
            Button BorrarU = FindViewById<Button>(Resource.Id.m_BUltimo);
            Button BorrarT = FindViewById<Button>(Resource.Id.m_BTodos);
            EditText nTemp = FindViewById<EditText>(Resource.Id.m_n);
            TextView list = FindViewById<TextView>(Resource.Id.m_list);
            TextView result = FindViewById<TextView>(Resource.Id.m_Resultado);
            LinearLayout layout = FindViewById<LinearLayout>(Resource.Id.m_layout);

            List<Double> conjunto = new List<double>();

            var metrics = Resources.DisplayMetrics;
            var widthInDp = ConvertPixelsToDp(metrics.WidthPixels);
            var heightInDp = ConvertPixelsToDp(metrics.HeightPixels);
            list.SetWidth(widthInDp / 2);

             agregar.Click += delegate
            {
                if (nTemp.Text != "")
                {
                    Double x = Convert.ToDouble(nTemp.Text);
                    nTemp.Text = "";
                    conjunto.Add(x);
                    list.Text += "\n  " + x;
                }
            };

            BorrarU.Click += delegate
            {
                if (conjunto.Count > 0)
                {
                    conjunto.RemoveAt(conjunto.Count - 1);
                    list.Text = "Elementos: \n";
                    foreach (var x in conjunto)
                    {
                        list.Text += "  " + x + "\n";
                    }
                }
            };

            BorrarT.Click += delegate
            {
                conjunto.Clear();
                list.Text = "Elementos: \n";
            };

            Calcular.Click += delegate
            {
                if (conjunto.Count() == 0)
                    return;
                result.Text = "Resultado: " + Tecnicas.TecnicasConteo.reglaMultiplicativa(conjunto);
                result.Visibility = ViewStates.Visible;
            };
            //ListaV.AddView
            // Create your application here
        }

        private int ConvertPixelsToDp(float pixelValue)
        {
            var dp = (int)((pixelValue) / Resources.DisplayMetrics.Density);
            return dp;
        }
    }
}