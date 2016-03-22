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
    [Activity(Label = "Permutacion Circular", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class PC : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PC);

            // Create your application here
            Button calc = FindViewById<Button>(Resource.Id.pc_calcular);
            EditText n = FindViewById<EditText>(Resource.Id.pc_n);
            TextView result = FindViewById<TextView>(Resource.Id.pc_resultado);

            calc.Click += delegate
            {
                result.Text = "Resultado: " + Tecnicas.TecnicasConteo.permutacionCircular(Convert.ToDouble(n.Text));
                result.Visibility = ViewStates.Visible;
                n.Text = "";
            };
        }
    }
}