using Android.App;
using Android.Content;
using Android.Gms.Cast.Framework;
using Android.Gms.Cast.Framework.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
//using MediaManager.Library;
//using TestCast.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCast.Droid.Listeners
{
    public class RemoteMediaClientCallback : RemoteMediaClient.Callback
    {
        override
        public void OnMetadataUpdated() {
            System.Diagnostics.Debug.WriteLine("[CAST_CBK] MetadataUpdated");
        }

        override
        public void OnStatusUpdated()
        {
            System.Diagnostics.Debug.WriteLine("[CAST_CBK] StatusUpdated ");
        }
    }
}