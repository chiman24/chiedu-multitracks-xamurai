using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using Prism.Commands;
using System.Windows.Input;

namespace Xamurai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MercedesView : ContentView, INotifyPropertyChanged
	{	
		public MercedesView ()
		{
            IsExpanded = true;
            ToggleCollapseCommand = new DelegateCommand(ToggleCollapse);
            InitializeComponent ();
		}

        private void ToggleCollapse()
        {
            //if (DeviceInfo.Platform == DevicePlatform.Android)
            //{
            //BUG iOS pre7+: doesn't collapse the section, only makes the label invisible
            IsExpanded = !IsExpanded;
            OnPropertyChanged(nameof(IsExpanded));
            //}
        }

        public ICommand ToggleCollapseCommand { get; }

        public bool IsExpanded { get; set; }
    }
}

