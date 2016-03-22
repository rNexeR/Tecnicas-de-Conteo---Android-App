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

namespace Conteo
{
    [Activity(Label = "Variacion Con Repeticion", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class VCR : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.VCR);

            // Create your application here
            Button calc = FindViewById<Button>(Resource.Id.vcr_calcular);
            EditText n = FindViewById<EditText>(Resource.Id.vcr_n);
            EditText m = FindViewById<EditText>(Resource.Id.vcr_m);
            TextView result = FindViewById<TextView>(Resource.Id.vcr_resultado);

            calc.Click += delegate
            {
                result.Text = "Resultado: " + Tecnicas.TecnicasConteo.variacionConRepeticion(Convert.ToDouble(n.Text), Convert.ToDouble(m.Text));
                result.Visibility = ViewStates.Visible;
                n.Text = "";
                m.Text = "";
            };
        }
    }
}