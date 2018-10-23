using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
// using java from Jar
using Com.Squareup.Picasso;

namespace BindingTest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ImageView imageView = FindViewById<ImageView>(Resource.Id.imageView);

            // Use the Picasso jar library to load and display this image:
            Picasso.With(this)
                .Load("http://i.imgur.com/DvpvklR.jpg")
                .Into(imageView);
        }
    }
}