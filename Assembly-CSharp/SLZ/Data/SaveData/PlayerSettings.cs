using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;
using SLZ.VRMK;

namespace SLZ.Data.SaveData
{
	public sealed class PlayerSettings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private string _modified;

		private bool _inventoryHudEnabled;

		private bool _tooltipsEnabled;

		private float _haptics;

		private bool _rightHanded;

		private int _locomotionCurve;

		private float _locomotionDegreesPerSnap;

		private int _locomotionDirection;

		private int _locomotionSnapDegreesPerFrame;

		private bool _snapEnabled;

		private bool _virtualCrouchingEnabled;

		private float _playerHeight;

		private BodyVitals.MeasurementState _measurementPresets;

		private float _chestCircumference;

		private float _underbustCircumference;

		private float _waistCircumference;

		private float _hipsCircumference;

		private float _wingspanLength;

		private float _inseamLength;

		private float _offsetSitting;

		private float _offsetFloor;

		private bool _standing;

		private bool _beltLocationRight;

		private bool _bodyLogLocationRight;

		private float _volumeGlobal;

		private float _volumeMusic;

		private float _volumeSFX;

		private string _fallbackAvatar;

		private string _currentAvatar;

		private List<string> _favoriteAvatar;

		private List<string> _favoriteSpawnables;

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

		[JsonProperty("inventory_hud_enabled")]
		public bool InventoryHudEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("tooltips_enabled")]
		public bool TooltipsEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("haptics")]
		public float Haptics
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("right_handed")]
		public bool RightHanded
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("locomotion_curve")]
		public int LocomotionCurve
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("locomotion_degrees_per_snap")]
		public float LocomotionDegreesPerSnap
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("locomotion_direction")]
		public int LocomotionDirection
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("locomotion_snap_degrees_per_frame")]
		public int LocomotionSnapDegreesPerFrame
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("snap_enabled")]
		public bool SnapEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("virtual_crouching_enabled")]
		public bool VirtualCrouchingEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("player_height")]
		public float PlayerHeight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("measurement_presets")]
		public BodyVitals.MeasurementState MeasurementPresets
		{
			get
			{
				return default(BodyVitals.MeasurementState);
			}
			set
			{
			}
		}

		[JsonProperty("chest_circumference")]
		public float ChestCircumference
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("underbust_circumference")]
		public float UnderbustCircumference
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("waist_circumference")]
		public float WaistCircumference
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("hips_circumference")]
		public float HipsCircumference
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("wingspan_length")]
		public float WingspanLength
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("inseam_length")]
		public float InseamLength
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("offset_sitting")]
		public float OffsetSitting
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("offset_floor")]
		public float OffsetFloor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("standing")]
		public bool Standing
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("belt_location_right")]
		public bool BeltLocationRight
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("body_log_location_right")]
		public bool BodyLogLocationRight
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("volume_global")]
		public float VolumeGlobal
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("volume_music")]
		public float VolumeMusic
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("volume_sfx")]
		public float VolumeSFX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[JsonProperty("fallback_avatar")]
		public string FallbackAvatar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("current_avatar")]
		public string CurrentAvatar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("favorite_avatars")]
		public List<string> FavoriteAvatars
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("favorite_spawnables")]
		public List<string> FavoriteSpawnables
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

		public PlayerSettings()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
