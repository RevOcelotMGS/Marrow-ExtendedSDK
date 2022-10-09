using System.ComponentModel;
using System.Runtime.CompilerServices;
using SLZ.Data.SaveData;

namespace SLZ.Data
{
	public sealed class DataManager
	{
		private static DataManager _instance;

		private Settings _settings;

		private Save _activeSave;

		public static DataManager Instance
		{
			get
			{
				return null;
			}
		}

		internal static string SettingsPath
		{
			get
			{
				return null;
			}
		}

		internal static string SavePath
		{
			get
			{
				return null;
			}
		}

		public static Settings Settings
		{
			get
			{
				return null;
			}
		}

		public static Save ActiveSave
		{
			get
			{
				return null;
			}
		}

		public static void MSAFAIGE()
		{
		}

		public static void KillAndReplaceActiveSave()
		{
		}

		public static bool TrySaveSettings()
		{
			return default(bool);
		}

		public static void PublishEvent<T>(string eventName, object sender, T obj)
		{
		}

		public static bool TryLoadActiveSave(SaveFlags flags)
		{
			return default(bool);
		}

		public static bool TrySaveActiveSave(SaveFlags flags)
		{
			return default(bool);
		}

		private void _MSAFAIGE()
		{
		}

		private void _killAndReplaceActiveSave()
		{
		}

		private void OnGameSaving(SaveFlags flags)
		{
		}

		private void OnGameSaved(SaveFlags flags, bool cancelledOrFailed, Save save)
		{
		}

		private void OnGameLoading(SaveFlags flags)
		{
		}

		private void OnGameLoaded(SaveFlags flags, bool cancelledOrFailed, Save save)
		{
		}

		private void _publishEvent<T>(string eventName, object sender, T obj)
		{
		}

		private DataManager()
			: base()
		{
		}

		private static bool _loadOrCreateSettings(Settings settings)
		{
			return default(bool);
		}

		private static bool _tryLoadAndParseSettings(Settings settings)
		{
			return default(bool);
		}

		private static bool _trySaveSettings(Settings settings)
		{
			return default(bool);
		}

		private bool _tryLoadActiveSave(SaveFlags flags)
		{
			return default(bool);
		}

		public bool _trySaveActiveSave(SaveFlags flags)
		{
			return default(bool);
		}

		private bool _tryLoadSave(Save save, string filename, SaveFlags flags = SaveFlags.Progression)
		{
			return default(bool);
		}

		private bool _trySaveSaveAs(Save save, string saveFilename, SaveFlags flags)
		{
			return default(bool);
		}

		private void OnSettingsPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void OnSavePropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void OnSavePropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		public event OnSavingEventHandler GameSaving;

		public event OnSavedEventHandler GameSaved;

		public event OnLoadingEventHandler GameLoading;

		public event OnLoadedEventHandler GameLoaded;

		public event OnDataManagerEventHandler DataManagerEventPublished;
	}
}
