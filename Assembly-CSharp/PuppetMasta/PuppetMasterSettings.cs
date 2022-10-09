using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

namespace PuppetMasta
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/PuppetMaster Settings")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		public class PuppetUpdateLimit
		{
			[Range(1f, 100f)]
			public int puppetsPerFrame;

			private int index;

			public void Step(int puppetCount)
			{
			}

			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}

			public PuppetUpdateLimit()
				: base()
			{
			}
		}

		[Header("Optimizations")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		public PuppetUpdateLimit freeUpdateLimit;

		public PuppetUpdateLimit fixedUpdateLimit;

		public bool collisionStayMessages;

		public bool collisionExitMessages;

		public float activePuppetCollisionThresholdMlp;

		private List<PuppetMaster> _puppets;

		public int currentlyActivePuppets { get; private set; }

		public int currentlyKinematicPuppets { get; private set; }

		public int currentlyDisabledPuppets { get; private set; }

		public List<PuppetMaster> puppets
		{
			get
			{
				return null;
			}
		}

		public void Register(PuppetMaster puppetMaster)
		{
		}

		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		public PuppetMasterSettings()
			: base()
		{
		}
	}
}
