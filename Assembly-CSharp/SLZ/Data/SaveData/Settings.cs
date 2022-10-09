using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.Data.SaveData
{
	public sealed class Settings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private int _version;

		private string _modified;

		private DebugSettings _debugSettings;

		private ModSettings _modSettings;

		private GraphicsSettings _graphicsSettings;

		private SpectatorSettings _spectatorSettings;

		private string _activeSave;

		[JsonProperty("version")]
		public int Version
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("modified")]
		public string Modified
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("active_save_game")]
		public string ActiveSave
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("debug_settings")]
		public DebugSettings DebugSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("mod_settings")]
		public ModSettings ModSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("graphics_settings")]
		public GraphicsSettings GraphicsSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("spectator_settings")]
		public SpectatorSettings SpectatorSettings
		{
			get
			{
				return null;
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

		private void DebugSettingsOnPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void DebugSettingsOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void ModSettingsOnPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void ModSettingsOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void GraphicsSettingsOnPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void GraphicsSettingsOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void SpectatorSettingsOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void SpectatorSettingsOnPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		public Settings()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
