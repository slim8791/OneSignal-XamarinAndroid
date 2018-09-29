using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.OneSignal;

namespace OneSignal_XamarinAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    { 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //This ligne is used to assign the app id from OneSignal
            OneSignal.Current.StartInit("4b2799ff-a4dd-41ca-959c-461d98aae354")
                  .EndInit();
        }
    }
}

