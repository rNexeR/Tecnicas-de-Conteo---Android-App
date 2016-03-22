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
    [Activity(Label = "Permutacion Con Repeticion", ScreenOrientation = ScreenOrientation.Portrait)]
    public class PCR : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PCR);

            Button agregar = FindViewById<Button>(Resource.Id.PCRAgregar);
            Button Calcular = FindViewById<Button>(Resource.Id.PCRCalcular);
            Button BorrarU = FindViewById<Button>(Resource.Id.PCRBUltimo);
            Button BorrarT = FindViewById<Button>(Resource.Id.PCRBTodos);
            EditText nTemp = FindViewById<EditText>(Resource.Id.PCRN);
            TextView list = FindViewById<TextView>(Resource.Id.textView2);
            TextView NTotal = FindViewById<TextView>(Resource.Id.NTotal);
            TextView result = FindViewById<TextView>(Resource.Id.PCRResultado);
            List<Double> conjunto = new List<double>();
            
            Double n = 0;

            var metrics = Resources.DisplayMetrics;
            var widthInDp = ConvertPixelsToDp(metrics.WidthPixels);
            var heightInDp = ConvertPixelsToDp(metrics.HeightPixels);
            list.SetWidth(widthInDp / 2);

             agregar.Click += delegate
            {
                if(nTemp.Text != "")
                {
                    Double x = Convert.ToDouble(nTemp.Text);
                    nTemp.Text = "";
                    conjunto.Add(x);
                    list.Text += "\n  " + x;
                    n += x;
                    NTotal.Text = "N = " + n;
                }
                
            };

            BorrarU.Click += delegate
            {
                if (conjunto.Count > 0)
                {
                    conjunto.RemoveAt(conjunto.Count - 1);
                    list.Text = "Elementos: \n";
                    n = 0;
                    foreach (var x in conjunto)
                    {
                        list.Text += "  " + x + "\n";
                        n += x;
                    }
                    NTotal.Text = "N = " + n;
                }
            };

            BorrarT.Click += delegate
            {
                conjunto.Clear();
                list.Text = "Elementos: \n";
                n = 0;
                NTotal.Text = "N = " + n;
            };

            Calcular.Click += delegate
            {
                if (conjunto.Count() == 0)
                    return;
                result.Text = "Resultado: " + Tecnicas.TecnicasConteo.permutacionConRepeticion(n, conjunto);
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