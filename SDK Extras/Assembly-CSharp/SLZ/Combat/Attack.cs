using System;
using SLZ.AI;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Combat
{
	[Serializable]
	public struct Attack
	{
		public float damage;

		public Vector3 normal;

		public Vector3 origin;

		public Vector3 direction;

		public bool backFacing;

		public int OrderInPool;

		public Collider collider;

		public AttackType attackType;

		public TriggerRefProxy proxy;
	}
}
