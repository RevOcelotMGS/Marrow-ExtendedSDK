using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.Data.SaveData
{
	public sealed class SpectatorSettings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private EyeTarget _eyeOutput;

		private SpectatorCameraMode _spectatorCameraMode;

		private int _resolutionX;

		private int _resolutionY;

		[JsonProperty("eye_output")]
		public EyeTarget EyeOutput
		{
			get
			{
				return default(EyeTarget);
			}
			set
			{
			}
		}

		[JsonProperty("spectator_camera_mode")]
		public SpectatorCameraMode SpectatorCameraMode
		{
			get
			{
				return default(SpectatorCameraMode);
			}
			set
			{
			}
		}

		[JsonProperty("resolution_x")]
		public int ResolutionX
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("resolution_y")]
		public int ResolutionY
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

		public SpectatorSettings()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
