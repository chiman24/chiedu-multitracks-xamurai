using System;
using UIKit;
using Xamurai.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(HideDeviceStatusBarImpl))]
namespace Xamurai.iOS
{
    /**
     * Implement hiding status bar on iOS devices.
     */
	public class HideDeviceStatusBarImpl : IDeviceStatusBar
	{
		public HideDeviceStatusBarImpl()
		{
		}

        public void HideDeviceStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
        }

        public void ShowDeviceStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
        }
    }
}

