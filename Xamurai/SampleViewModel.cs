using Acr.UserDialogs;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;


namespace Xamurai
{
	public class SampleViewModel : BindableBase
	{
		public SampleViewModel()
		{
			GridSpan = Device.Idiom == TargetIdiom.Phone ? 1 : 2;
			BuildCars();
			DeleteCommand = new Command(deleteItem);
			LongPressCommand = new Command(OnLongPress);
		}

		private int _gridSpan;

		public int GridSpan
		{
			get { return _gridSpan; }
			set { SetProperty(ref _gridSpan, value); }
		}

		private void BuildCars()
		{
			Cars = new ObservableCollection<Car>
			{
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Notes = "test car", Description = "This is a Volkswagen!", Color = Color.Black },
				new Car { Abbreviation = "BMW", Make=CarMake.BMW, Name = "X5", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 10)), Color = Color.Purple },
				new Car { Abbreviation = "M", Make=CarMake.Mercedes, Name = "AMG C Class", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.CornflowerBlue},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.Brown },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.Orange },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.DarkBlue },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 7)), Color = Color.DarkOrange },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.OrangeRed },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 4)), Color = Color.Violet},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 2)), Color = Color.DarkSalmon },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.Green },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 6)), Color = Color.GreenYellow},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.LawnGreen},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.SkyBlue },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.LightCyan },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.PaleTurquoise },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.Purple },

			};
		}

		private ObservableCollection<Car> _cars;

		public ObservableCollection<Car> Cars
		{
			get { return _cars; }
			set { SetProperty(ref _cars, value); }
		}

		public ICommand DeleteCommand { get; }
		public ICommand LongPressCommand { get; }
	
		void deleteItem(object obj)
		{
			Car item = (Car)obj;
			Cars.Remove(item);
		}

		void OnLongPress(object obj)
		{
			UserDialogs.Instance.Confirm(new ConfirmConfig
			{
				Title = "Delete",
				Message = "Do you want to delete?",
				OkText = "Yes",
				CancelText = "No",
				OnAction = (confirmed) => {
					if (confirmed)
						deleteItem(obj);
				}
			});
		}
	}
}
