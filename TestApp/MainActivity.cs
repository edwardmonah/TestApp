using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Widget;

namespace TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView textNumber;
        int number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textNumber = FindViewById<TextView>(Resource.Id.textView1);

            FindViewById<Button>(Resource.Id.buttonIncrement).Click += (o, e) =>
            textNumber.Text = (++number).ToString();

            FindViewById<Button>(Resource.Id.buttonDecrement).Click += (o, e) =>
            textNumber.Text = (--number).ToString();

        }

 
	}
}
