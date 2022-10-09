using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Bomb")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-bomb-component/")]
	public class RayfireBomb : MonoBehaviour
	{
		public enum RangeType
		{
			Spherical = 0
		}

		public enum FadeType
		{
			Linear = 0,
			Exponential = 1,
			None = 2
		}

		[Serializable]
		public class Projectile
		{
			public Vector3 positionPivot;

			public Vector3 positionClosest;

			public float fade;

			public Rigidbody rb;

			public RayfireRigid rigid;

			public Quaternion rotation;

			public RFShard shard;

			public RayfireRigidRoot rigidRoot;

			public Projectile()
				: base()
			{
			}
		}

		public bool showGizmo;

		public RangeType rangeType;

		public FadeType fadeType;

		public float range;

		public int deletion;

		public float strength;

		public int variation;

		public int chaos;

		public bool forceByMass;

		public bool affectInactive;

		public bool affectKinematic;

		public float heightOffset;

		public float delay;

		public bool atStart;

		public bool destroy;

		public bool applyDamage;

		public float damageValue;

		public bool play;

		public float volume;

		public AudioClip clip;

		public RFExplosionEvent explosionEvent;

		[HideInInspector]
		public Vector3 bombPosition;

		[HideInInspector]
		public Vector3 explPosition;

		[HideInInspector]
		public Collider[] colliders;

		[HideInInspector]
		public List<Rigidbody> rigidbodies;

		[HideInInspector]
		public int mask;

		[HideInInspector]
		public string tagFilter;

		[NonSerialized]
		private List<Projectile> projectiles;

		[NonSerialized]
		private List<Projectile> deletionProjectiles;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void CopyFrom(RayfireBomb scr)
		{
		}

		public void Explode(float delayLoc)
		{
		}

		private IEnumerator ExplodeCor()
		{
			return null;
		}

		private void Explode()
		{
		}

		private void PlayAudio()
		{
		}

		private bool Setup()
		{
			return default(bool);
		}

		private void ClearLists()
		{
		}

		public void Restore()
		{
		}

		private static void RestoreProjectiles(List<Projectile> prj)
		{
		}

		private void SetPositions()
		{
		}

		private void SetColliders()
		{
		}

		private void SetProjectiles()
		{
		}

		private bool SetRigidDamage()
		{
			return default(bool);
		}

		private void Deletion()
		{
		}

		private void Activate()
		{
		}

		private void SetForce()
		{
		}

		private float Fade(Vector3 bombPos, Vector3 fragPos)
		{
			return default(float);
		}

		private Vector3 Vector(Projectile projectile)
		{
			return default(Vector3);
		}

		public RayfireBomb()
			: base()
		{
		}
	}
}
