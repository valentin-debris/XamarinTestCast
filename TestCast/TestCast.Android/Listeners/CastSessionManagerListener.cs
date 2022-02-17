using Android.App;
using Android.Content;
using Android.Gms.Cast.Framework;
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
using TestCast.Droid;

namespace TestCast.Droid.Listeners
{
    //Setup based on Google Sample Code : https://github.com/googlecast/CastVideos-android/blob/master/src/com/google/sample/cast/refplayer/mediaplayer/LocalPlayerActivity.java#L172
    public class CastSessionManagerListener : Java.Lang.Object, ISessionManagerListener
    {
        public void OnSessionEnded(Java.Lang.Object session, int error)
        {
            //Update Tracking session?
            System.Diagnostics.Debug.WriteLine("[CAST] SESSION ENDED");

            OnApplicationDisconnected();
        }

        public void OnSessionResumed(Java.Lang.Object session, bool wasSuspended)
        {
            System.Diagnostics.Debug.WriteLine("[CAST] SESSION RESUMED");
            //Cast connected successfully
            CastSession castSession = session as CastSession;


            OnApplicationConnected(castSession);
        }

        public void OnSessionResumeFailed(Java.Lang.Object session, int error)
        {
            //Update Tracking session?
            System.Diagnostics.Debug.WriteLine("[CAST] SESSION RESUME FAILED");

            OnApplicationDisconnected();
        }


        public void OnSessionStarted(Java.Lang.Object session, string sessionId)
        {
            System.Diagnostics.Debug.WriteLine("[CAST] SessStarted");
            //Cast connected successfully
            CastSession castSession = session as CastSession;

            OnApplicationConnected(castSession);
        }

        public void OnSessionStartFailed(Java.Lang.Object session, int error)
        {
            //Update Tracking session?
            System.Diagnostics.Debug.WriteLine("[CAST] SESSION START FAILED");

            OnApplicationDisconnected();
        }

        public void OnSessionStarting(Java.Lang.Object session)
        {
            System.Diagnostics.Debug.WriteLine("[CAST] SessStarting");
        }

        public void OnSessionEnding(Java.Lang.Object session)
        {
            System.Diagnostics.Debug.WriteLine("[CAST] SessEnding");
        }

        public void OnSessionResuming(Java.Lang.Object session, string sessionId)
        {
            System.Diagnostics.Debug.WriteLine("[CAST] SessResuming");
        }

        public void OnSessionSuspended(Java.Lang.Object session, int reason)
        {
            System.Diagnostics.Debug.WriteLine("[CAST] SessSuspended");
        }

        private void OnApplicationConnected(CastSession castSession)
        {
            System.Diagnostics.Debug.WriteLine("[CAST] SESSION :: " + castSession);
            //try
            //{
            //    var remoteClient = castSession.RemoteMediaClient;

            //    if (remoteClient != null)
            //    {
            //        CastRemoteMediaClientProgressListener castRemoteMediaClientProgressListener = new CastRemoteMediaClientProgressListener();
            //        remoteClient.AddProgressListener(castRemoteMediaClientProgressListener, 1000);
            //        remoteClient.RegisterCallback(new RemoteMediaClientCallback(playeractivity));
            //    }

            //    if (remoteClient != null && remoteClient.MediaInfo != null)
            //    {
            //    }
            //}
            //catch (Exception ex)
            //{ }
        }

        private void OnApplicationDisconnected()
        {
            System.Diagnostics.Debug.WriteLine("[CAST] OOPSY Happened !");
        }
    }
}