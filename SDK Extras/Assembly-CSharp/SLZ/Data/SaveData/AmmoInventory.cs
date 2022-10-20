using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.Data.SaveData
{
	public class AmmoInventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private int _ammoGlobalLight;

		private int _ammoGlobalMedium;

		private int _ammoGlobalHeavy;

		[JsonProperty("ammo_global_light")]
		public int AmmoGlobalLight
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("ammo_global_medium")]
		public int AmmoGlobalMedium
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("ammo_global_heavy")]
		public int AmmoGlobalHeavy
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = default(string))
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = default(string))
		{
		}

		public AmmoInventory()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
