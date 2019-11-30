using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace ThirdApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var listView = FindViewById<ListView>(Resource.Id.listView1);

            var carList = new List<Car> 
            {
                new Car() { Manufactorer = "Tesla", Model = "CyberTruck", KW = 300 },
                new Car() { Manufactorer = "Ford", Model = "Fiesta", KW = 80 },
                new Car() { Manufactorer = "Mercedes", Model = "E", KW = 145 },
                new Car() { Manufactorer = "Ford", Model = "Focus", KW = 60 },
                new Car() { Manufactorer = "Subaru", Model = "Impreza", KW = 200 },
                new Car() { Manufactorer = "Lada", Model = "Niva", KW = 400 },               
            };


            listView.Adapter = new BasicAdapter(this, carList);
            
            listView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };

        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}