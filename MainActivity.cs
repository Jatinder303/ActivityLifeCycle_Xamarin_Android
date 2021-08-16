using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace ActivityLifeCycle_Xamarin_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
          //  Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Toast.MakeText(this, "On Create", ToastLength.Long).Show();
        }
		protected override void OnStart()
		{
			base.OnStart();
			Toast.MakeText(this, "On Start", ToastLength.Long).Show();
		}

		protected override void OnResume()
		{
			base.OnResume();
			Toast.MakeText(this, "On Resume", ToastLength.Long).Show();
		}

		protected override void OnRestart()
		{
			base.OnRestart();
			Toast.MakeText(this, "On Restart", ToastLength.Long).Show();
		}

		protected override void OnPause()
		{
			base.OnPause();
			Toast.MakeText(this, "On Pause", ToastLength.Long).Show();
		}

		protected override void OnStop()
		{
			base.OnStop();
			Toast.MakeText(this, "On Stop", ToastLength.Long).Show();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Toast.MakeText(this, "On Destroy", ToastLength.Long).Show();
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}