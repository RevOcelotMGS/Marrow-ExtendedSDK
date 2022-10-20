using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SLZ.Data.SaveData
{
	public sealed class DebugSettings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private bool _developerMode;

		[JsonExtensionData]
		public IDictionary<string, JToken> AdditionalData { get; set; }

		[JsonProperty("developer_mode")]
		public bool DeveloperMode
		{
			get
			{
				return default(bool);
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

		public DebugSettings()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
