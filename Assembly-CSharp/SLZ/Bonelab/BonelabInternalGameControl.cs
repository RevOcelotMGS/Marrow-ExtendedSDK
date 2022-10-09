using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public abstract class BonelabInternalGameControl : BonelabGameControl
	{
		protected LevelCrateReference NextCampaignLevel { get; set; }

		protected List<GenericCrateReference> Unlocks { get; set; }

		protected double LevelLoadBufferTime { get; set; }

		public void SetHubSpawnLocation(int hubSpawnLocation)
		{
		}

		public void JustJumpToLevel(LevelCrateReference level)
		{
		}

		public void LevelComplete()
		{
		}

		public UniTaskVoid LevelCompleteWithDelayAsync(TimeSpan timeSpan)
		{
			return default(UniTaskVoid);
		}

		public virtual void DoLevelComplete()
		{
		}

		public BonelabInternalGameControl()
			: base()
		{
		}
	}
}
