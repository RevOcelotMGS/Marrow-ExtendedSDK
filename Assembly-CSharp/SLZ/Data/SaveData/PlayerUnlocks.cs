using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.Data.SaveData
{
	public class PlayerUnlocks : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private Dictionary<string, int> _unlocks;

		[JsonProperty("unlocks")]
		private Dictionary<string, int> Unlocks
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int UnlockCountForBarcode(string barcode)
		{
			return default(int);
		}

		public int IncrementUnlockForBarcode(string barcode)
		{
			return default(int);
		}

		public bool ClearUnlockForBarcode(string barcode)
		{
			return default(bool);
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = default(string))
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = default(string))
		{
		}

		public PlayerUnlocks()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
