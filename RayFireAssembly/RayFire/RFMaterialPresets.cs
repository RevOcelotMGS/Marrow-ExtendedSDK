using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFMaterialPresets
	{
		public RFMaterial heavyMetal;

		public RFMaterial lightMetal;

		public RFMaterial denseRock;

		public RFMaterial porousRock;

		public RFMaterial concrete;

		public RFMaterial brick;

		public RFMaterial glass;

		public RFMaterial rubber;

		public RFMaterial ice;

		public RFMaterial wood;

		public void SetMaterials()
		{
		}

		public float Density(MaterialType materialType)
		{
			return default(float);
		}

		public float Drag(MaterialType materialType)
		{
			return default(float);
		}

		public float AngularDrag(MaterialType materialType)
		{
			return default(float);
		}

		public int Solidity(MaterialType materialType)
		{
			return default(int);
		}

		public bool Destructible(MaterialType materialType)
		{
			return default(bool);
		}

		public static PhysicMaterial Material(MaterialType materialType)
		{
			return null;
		}

		public RFMaterialPresets()
			: base()
		{
		}
	}
}
