using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ
{
	public class SimpleParticleSpawner : MonoBehaviour
	{
		[SerializeField]
		public Spawnable particleBlasterSpawnable;

		[SerializeField]
		private bool PlayOnEnable;

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		public void SpawnParticles()
		{
		}

		public void SpawnParticles(Collider collider, Vector3 pos, Vector3 norm)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public SimpleParticleSpawner()
			: base()
		{
		}
	}
}
