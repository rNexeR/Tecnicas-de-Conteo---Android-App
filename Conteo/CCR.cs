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
    [Activity(Label = "Combinacion Con Repeticion", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class CCR : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CCR);

            // Create your application here
            Button calc = FindViewById<Button>(Resource.Id.ccr_calcular);
            EditText n = FindViewById<EditText>(Resource.Id.ccr_n);
            EditText m = FindViewById<EditText>(Resource.Id.ccr_m);
            TextView result = FindViewById<TextView>(Resource.Id.ccr_resultado);

            calc.Click += delegate
            {
                result.Text = "Resultado: " + Tecnicas.TecnicasConteo.combinacionConRepeticion(Convert.ToDouble(n.Text), Convert.ToDouble(m.Text));
                result.Visibility = ViewStates.Visible;
                n.Text = "";
                m.Text = "";
            };
        }
    }
}