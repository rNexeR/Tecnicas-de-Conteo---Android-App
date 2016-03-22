using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Conteo
{
    [Activity(Label = "Tecnicas de Conteo", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button PSR = FindViewById<Button>(Resource.Id.PSR);
            Button PCR = FindViewById<Button>(Resource.Id.PCR);
            Button CSR = FindViewById<Button>(Resource.Id.CSR);
            Button CCR = FindViewById<Button>(Resource.Id.CCR);
            Button VSR = FindViewById<Button>(Resource.Id.VSR);
            Button VCR = FindViewById<Button>(Resource.Id.VCR);
            Button PC = FindViewById<Button>(Resource.Id.PC);
            Button RM = FindViewById<Button>(Resource.Id.RM);
            Button RA = FindViewById<Button>(Resource.Id.RA);

            PSR.Click += delegate {
                StartActivity(typeof(PSC));
            };

            PCR.Click += delegate {
                StartActivity(typeof(PCR));
            };

            CSR.Click += delegate {
                StartActivity(typeof(CSR));
            };

            CCR.Click += delegate {
                StartActivity(typeof(CCR));
            };

            VSR.Click += delegate {
                StartActivity(typeof(VSR));
            };

            VCR.Click += delegate {
                StartActivity(typeof(VCR));
            };

            PC.Click += delegate {
                StartActivity(typeof(PC));
            };

            RM.Click += delegate {
                StartActivity(typeof(Multiplicativa));
            };

            RA.Click += delegate {
                StartActivity(typeof(Aditiva));
            };

        }
    }
}

