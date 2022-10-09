using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RayFire
{
	[Serializable]
	public class RFActivation
	{
		public bool local;

		public float byOffset;

		public float byVelocity;

		public float byDamage;

		public bool byActivator;

		public bool byImpact;

		public bool byConnectivity;

		public bool unyielding;

		public bool activatable;

		public string layer;

		public RayfireConnectivity connect;

		[NonSerialized]
		public bool activated;

		[NonSerialized]
		public bool inactiveCorState;

		[NonSerialized]
		public bool velocityCorState;

		[NonSerialized]
		public bool offsetCorState;

		[NonSerialized]
		public IEnumerator velocityEnum;

		[NonSerialized]
		public IEnumerator offsetEnum;

		public void CopyFrom(RFActivation act)
		{
		}

		public void Reset()
		{
		}

		public void CheckConnectivity()
		{
		}

		public IEnumerator ActivationVelocityCor(RayfireRigid scr)
		{
			return null;
		}

		public IEnumerator ActivationOffsetCor(RayfireRigid scr)
		{
			return null;
		}

		public IEnumerator InactiveCor(RayfireRigid scr)
		{
			return null;
		}

		public IEnumerator InactiveCor(RayfireRigidRoot scr)
		{
			return null;
		}

		public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
		{
		}

		public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
		{
			return default(bool);
		}

		private static void SetRigidActivationLayer(RayfireRigid scr)
		{
		}

		public RFActivation()
			: base()
		{
		}
	}
}
