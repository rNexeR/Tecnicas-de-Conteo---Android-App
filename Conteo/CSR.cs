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
    [Activity(Label = "Combinacion Sin Repeticion", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class CSR : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CSR);

            // Create your application here
            Button calc = FindViewById<Button>(Resource.Id.csr_calcular);
            EditText n = FindViewById<EditText>(Resource.Id.csr_n);
            EditText m = FindViewById<EditText>(Resource.Id.csr_m);
            TextView result = FindViewById<TextView>(Resource.Id.csr_resultado);

            calc.Click += delegate
            {
                result.Text = "Resultado: " + Tecnicas.TecnicasConteo.combinacionSinRepeticion(Convert.ToDouble(n.Text), Convert.ToDouble(m.Text));
                result.Visibility = ViewStates.Visible;
                n.Text = "";
                m.Text = "";
            };
        }
    }
}