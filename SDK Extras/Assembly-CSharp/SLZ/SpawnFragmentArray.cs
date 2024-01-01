using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Props
{
	public class SpawnFragmentArray : MonoBehaviour
	{
		public float massPercentage;

		public int fragmentCount;

		[Tooltip("Set override material, otherwise will default to fragments material.")]
		public Material fragmentMaterial;

		[HideInInspector]
		public TextureArrayApplicator applicator;

		[HideInInspector]
		public int applicatorTextureIndex;

		[HideInInspector]
		public int applicatorTextureIndex2;

		[HideInInspector]
		public Color applicatorColor;

		public int fragmentSFXCount;

		public bool isRandom;

		public Transform[] fragmentSpawnPoints;

		private List<int> _fragmentIndicesBuffer;

		private int[] _randomFragmentIndices;

		[Space(10f)]
		[Header("DEPENDENCIES")]
		public Spawnable fragmentSpawnable;

		private void Awake()
		{
		}

		private void FragmentSpawner(int idx, int count, Vector3 velocity, Vector3 angularVelocity, float mass, Vector3 worldCenter, float explosiveForce)
		{
		}

		public void Spawn(Rigidbody parentRB, Vector3 velocity, Vector3 angularVelocity, Vector3 worldCenter, float explosiveForce)
		{
		}

		public SpawnFragmentArray()
			: base()
		{
		}
	}
}
