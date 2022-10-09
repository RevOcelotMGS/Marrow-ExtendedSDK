using SLZ.Data;
using UnityEngine;

namespace SLZ.Combat
{
	public abstract class ImpactPropertiesVariables : MonoBehaviour
	{
		public enum DecalType
		{
			mesh = 0,
			plane = 1,
			none = 2
		}

		[HideInInspector]
		public enum Material
		{
			Default = 0,
			Metal = 1,
			PureMetal = 2,
			Wood = 3,
			Dirt = 4,
			Cardboard = 5,
			Glass = 6,
			Blood = 7,
			Water = 8,
			Zapper = 9,
			Concrete = 10,
			Hydraulic = 11,
			Bioluminescent = 12
		}

		[HideInInspector]
		public enum ModelType
		{
			Skinned = 0,
			Flat = 1,
			Model = 2,
			Ignore = 3,
			LightCone = 4
		}

		[Header("Options")]
		public SurfaceData surfaceData;

		public GameObject DecalMeshObj;

		public DecalType decalType;

		[HideInInspector]
		public Material material;

		[Tooltip("Define type of target Mesh for Decal System")]
		[HideInInspector]
		public ModelType modelType;

		[Header("Particle Color")]
		[HideInInspector]
		public Color MainColor;

		[HideInInspector]
		public Color SecondaryColor;

		[Header("Ballistics")]
		[Range(0.001f, 1f)]
		[HideInInspector]
		public float PenetrationResistance;

		[HideInInspector]
		public float megaPascalModifier;

		[Header(null)]
		[HideInInspector]
		public bool Flammable;

		[Tooltip("Fire Resistance in C")]
		[HideInInspector]
		public float FireResistance;

		public ImpactPropertiesVariables()
			: base()
		{
		}
	}
}
