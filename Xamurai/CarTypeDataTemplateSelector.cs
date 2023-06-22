using System;
using Xamarin.Forms;
namespace Xamurai
{
	public class CarTypeDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate MercedesTemplate { get; set; }
		public DataTemplate NonMercedesTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
			return ((Car)item).Make.Equals(CarMake.Mercedes) ? MercedesTemplate : NonMercedesTemplate;
        }
    }
}

