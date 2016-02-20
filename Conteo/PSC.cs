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
    [Activity(Label = "Permutacion Sin Repeticion", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class PSC : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PSC);

            // Create your application here
            Button calc = FindViewById<Button>(Resource.Id.Calcular);
            EditText n = FindViewById<EditText>(Resource.Id.n);
            TextView result = FindViewById<TextView>(Resource.Id.Resultado);

            calc.Click += delegate
            {
                result.Text = "Resultado: " + Tecnicas.TecnicasConteo.permutacionSinRepeticion(Convert.ToDouble(n.Text));
                result.Visibility = ViewStates.Visible;
            };
        }
    }
}