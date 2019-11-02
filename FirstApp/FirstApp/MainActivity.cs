using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.first_layout);

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            var textView2 = FindViewById<TextView>(Resource.Id.textView2);

            var button = FindViewById<Button>(Resource.Id.button1);
            var button2 = FindViewById<Button>(Resource.Id.button2);

            var textfield = FindViewById<EditText>(Resource.Id.editText1);
            var textfield2 = FindViewById<EditText>(Resource.Id.editText2);
            



            var value = textfield.Text;

            button.Click += delegate
            {
                textView.Text = "IT WORKS!";
            };

            button2.Click += delegate
            {
                var test = int.Parse(textfield.Text) + int.Parse(textfield2.Text);
                textfield2.Text = test.ToString();
            };
        }
    }
}