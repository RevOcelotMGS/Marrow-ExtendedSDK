using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Gun")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-gun-component/")]
	public class RayfireGun : MonoBehaviour
	{
		public enum ImpactType
		{
			AddExplosionForce = 0,
			AddForceAtPosition = 1
		}

		public AxisType axis;

		public float maxDistance;

		public Transform target;

		public int rounds;

		public float rate;

		public ImpactType type;

		public float strength;

		public float radius;

		public bool demolishCluster;

		public bool affectInactive;

		public bool rigid;

		public bool rigidRoot;

		[FormerlySerializedAs("affectRigidBodies")]
		public bool rigidBody;

		public float damage;

		public bool debris;

		public bool dust;

		public bool flash;

		public RFFlash Flash;

		public int mask;

		public string tagFilter;

		public bool showRay;

		public bool showHit;

		public bool shooting;

		private static string untagged;

		public RFShotEvent shotEvent;

		private Collider[] impactColliders;

		public Vector3 ShootVector
		{
			get
			{
				return default(Vector3);
			}
		}

		public void StartShooting()
		{
		}

		private IEnumerator StartShootCor()
		{
			return null;
		}

		public void StopShooting()
		{
		}

		public void Shoot(int shootId = 1)
		{
		}

		public void Burst()
		{
		}

		private IEnumerator BurstCor()
		{
			return null;
		}

		public void Shoot(Vector3 shootPos, Vector3 shootVector)
		{
		}

		private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
		{
		}

		private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
		{
		}

		private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
		{
		}

		private RayfireRigid ApplyDamage(RayfireRigid scrRigid, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
		{
			return null;
		}

		private void VfxFlash(Vector3 position, Vector3 normal)
		{
		}

		private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
		{
		}

		private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
		{
		}

		private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
		{
			return null;
		}

		public RayfireGun()
			: base()
		{
		}
	}
}
