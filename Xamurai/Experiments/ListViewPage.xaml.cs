using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
        
		public ListViewPage ()	
		{
			BindingContext = new SampleViewModel();
            InitializeComponent();
            HideDeviceStatusBar();
		}


        //Hide device status bar when this page loads.
        //Implemented in Android and iOS, but currently only works on Android.
        private void HideDeviceStatusBar()
        {    
            DependencyService.Get<IDeviceStatusBar>().HideDeviceStatusBar();
        }
    }
}