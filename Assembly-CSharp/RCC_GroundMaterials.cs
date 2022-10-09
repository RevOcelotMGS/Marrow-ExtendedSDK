using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "GroundMaterials", menuName = "StressLevelZero / GroundMaterials", order = 1)]
public class RCC_GroundMaterials : ScriptableObject
{
	[Serializable]
	public class GroundMaterialFrictions
	{
		public PhysicMaterial groundMaterial;

		public float forwardStiffness;

		public float sidewaysStiffness;

		public float slip;

		public float damp;

		[Range(0f, 1f)]
		public float volume;

		public GameObject groundParticles;

		public AudioClip groundSound;

		public RCC_Skidmarks skidmark;

		public GroundMaterialFrictions()
			: base()
		{
		}
	}

	[Serializable]
	public class TerrainFrictions
	{
		[Serializable]
		public class SplatmapIndexes
		{
			public int index;

			public PhysicMaterial groundMaterial;

			public SplatmapIndexes()
				: base()
			{
			}
		}

		public PhysicMaterial groundMaterial;

		public SplatmapIndexes[] splatmapIndexes;

		public TerrainFrictions()
			: base()
		{
		}
	}

	public GroundMaterialFrictions[] frictions;

	public TerrainFrictions[] terrainFrictions;

	public RCC_GroundMaterials()
		: base()
	{
	}
}
