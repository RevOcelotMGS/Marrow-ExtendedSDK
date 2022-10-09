using UnityEngine;

namespace PuppetMasta
{
	public struct MuscleCollision
	{
		public int muscleIndex;

		public Collision collision;

		public bool isStay;

		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
			this.isStay = default(bool);
			this.collision = default(Collision);
			this.muscleIndex = default(int);
		}
	}
}
