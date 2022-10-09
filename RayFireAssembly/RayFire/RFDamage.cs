using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFDamage
	{
		public bool enable;

		public float maxDamage;

		public float currentDamage;

		public bool collect;

		public float multiplier;

		public void CopyFrom(RFDamage damage)
		{
		}

		public void Reset()
		{
		}

		public static bool Apply(RayfireRigid scr, float damageValue)
		{
			return default(bool);
		}

		public static bool ApplyDamage(RayfireRigid scr, float damageValue, Vector3 damagePoint, float damageRadius = 0f)
		{
			return default(bool);
		}

		public RFDamage()
			: base()
		{
		}
	}
}
