using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.Data.SaveData
{
	public class PlayerProgression : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private bool _beatGame;

		private bool _hasBodyLog;

		private bool _bodyLogEnabled;

		private string _currentCampaignLevel;

		private string _currentLevel;

		private int _menuResume;

		private Dictionary<string, Dictionary<string, object>> _levelState;

		[JsonProperty("beat_game")]
		public bool BeatGame
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("has_body_log")]
		public bool HasBodyLog
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("body_log_enabled")]
		public bool BodyLogEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("current_campaign_level")]
		public string CurrentCampaignLevel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("current_level")]
		public string CurrentLevel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("menu_resume")]
		public int MenuResume
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("level_state")]
		public Dictionary<string, Dictionary<string, object>> LevelState
		{
			get
			{
				return null;
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

		public PlayerProgression()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
