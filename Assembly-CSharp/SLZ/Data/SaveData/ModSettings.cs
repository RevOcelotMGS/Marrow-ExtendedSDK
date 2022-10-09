using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.Data.SaveData
{
	public sealed class ModSettings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private int _maxConnections;

		private int _maxPerHost;

		private int _timeout;

		[JsonProperty("max_connections")]
		public int MaxConnections
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("max_per_host")]
		public int MaxPerHost
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("timeout")]
		public int Timeout
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public void FixFieldsIfNeeded()
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = default(string))
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = default(string))
		{
		}

		public ModSettings()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
