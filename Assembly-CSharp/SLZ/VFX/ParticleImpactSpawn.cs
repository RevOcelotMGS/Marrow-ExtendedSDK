using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleImpactSpawn : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem PS;

		public Spawnable spawnable;

		public float Scaler;

		public float Scaler2;

		private List<ParticleCollisionEvent> collisionEvents;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnParticleCollision(GameObject Other)
		{
		}

		public ParticleImpactSpawn()
			: base()
		{
		}
	}
}
