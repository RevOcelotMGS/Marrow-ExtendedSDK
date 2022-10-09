using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFMaterial
	{
		private string name;

		public bool destructible;

		public int solidity;

		public float density;

		public float drag;

		public float angularDrag;

		public PhysicMaterial material;

		public float dynamicFriction;

		public float staticFriction;

		public float bounciness;

		public PhysicMaterial Material
		{
			get
			{
				return null;
			}
		}

		public RFMaterial(string Name, float Density, float Drag, float AngularDrag, int Solidity, bool Destructible, float DynFriction, float StFriction, float Bounce)
			: base()
		{
		}
	}
}
