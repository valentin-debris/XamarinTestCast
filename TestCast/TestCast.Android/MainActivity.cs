using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using TestCast.Services;
using TestCast.Droid.Listeners;
using Android.Gms.Cast.Framework;
using Xamarin.Forms;

namespace TestCast.Droid
{
    [Activity(Label = "TestCast", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());

            //CastSessionManagerListener castSessionManagerListener = new CastSessionManagerListener(this);
            CastContext castContext = CastContext.GetSharedInstance(this);
            //CastSession castSession = castContext.SessionManager.CurrentCastSession;
            //castContext.SessionManager.AddSessionManagerListener(castSessionManagerListener);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}