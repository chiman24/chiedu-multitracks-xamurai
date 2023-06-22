using System;
using Xamarin.Forms;
using Plugin.CurrentActivity;
using Android.App;
using Android.Views;
using Xamurai.Droid;

[assembly: Dependency(typeof(HideDeviceStatusBarImpl))]
namespace Xamurai.Droid
{
    /**
      * Implement hiding the status bar on Android devices
     */
    public class HideDeviceStatusBarImpl : IDeviceStatusBar
	{
		public HideDeviceStatusBarImpl()
		{
		}

        WindowManagerFlags _originalFlags;
        
        public void HideDeviceStatusBar()
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            var attributes = activity.Window.Attributes;
            _originalFlags = attributes.Flags;
            attributes.Flags |= WindowManagerFlags.Fullscreen;
            activity.Window.Attributes = attributes;
        }

        public void ShowDeviceStatusBar()
        {
            throw new NotImplementedException();
        }
    }
}

