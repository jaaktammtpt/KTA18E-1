﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace SecondApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var toSecondActivityButton = FindViewById<Button>(Resource.Id.button1);
            var editText = FindViewById<EditText>(Resource.Id.editText1);

            toSecondActivityButton.Click += delegate
            {
                var text = editText.Text;
                var intent = new Intent(this, typeof(SecondActivity));
                intent.PutExtra("editextvalue", text);
                StartActivity(intent);
            };
        }
    }
}