using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Data.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BonelabGameControl : MonoBehaviour
	{
		public static readonly LevelCrateReference HubLevel;

		[Tooltip("Name of the level in the save data")]
		public string LevelKey { get; protected set; }

		[Tooltip("Mark level complete after level load")]
		public bool CompleteOnLoad { get; protected set; }

		[Tooltip("Does this level save completion/progress/ammo/inventory?")]
		public SaveFeatures SaveFeatures { get; protected set; }

		[Tooltip("Crate reference to the loading screen level")]
		public LevelCrateReference LoadScreenLevel { get; protected set; }

		[Tooltip("Crate references to levels to possibly load")]
		public List<LevelCrateReference> LevelJumpList { get; protected set; }

		public RigManager PlayerRigManager { get; protected set; }

		public Spawnable VfxFadeOutSpawnable { get; protected set; }

		protected List<string> PriorLevels { get; set; }

		protected List<ResumePoint> ProgressionPoint { get; set; }

		public List<RegisteredSaveableInfo> RegisteredSaveables { get; set; }

		public InventorySaveFilter InventorySaveFilter { get; set; }

		public int Progress { get; protected set; }

		public bool IsResuming { get; protected set; }

		public static bool IsCompleted(PlayerProgression progression, string levelKey)
		{
			return default(bool);
		}

		public static void SetCompleted(PlayerProgression progression, string levelKey, bool completed)
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public void TeleportToProgress()
		{
		}

		private void ResumeProgress()
		{
		}

		public void SetCompleted()
		{
		}

		public void SetProgress(int progress)
		{
		}

		public void FinalizeAmmo()
		{
		}

		public void FinalizeInventory()
		{
		}

		public void JustSave()
		{
		}

		public void JustJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		public void FinalizeThenJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		public BonelabGameControl()
			: base()
		{
		}
	}
}
