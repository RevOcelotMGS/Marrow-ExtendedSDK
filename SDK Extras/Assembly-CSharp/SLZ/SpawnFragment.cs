using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ
{
	public class SpawnFragment : MonoBehaviour
	{
		private static ComponentCache<SpawnFragment> _cache;

		[SerializeField]
		private Renderer[] matRenderer;

		public Rigidbody[] rigidbodies;

		public ImpactSFX[] sfx;

		private Renderer _activeFragment;

		public static ComponentCache<SpawnFragment> Cache
		{
			get
			{
				return null;
			}
		}

		public void SetRigidbody(int idx, Vector3? velocity = default(Vector3?), Vector3? angularVelocity = default(Vector3?), float? mass = default(float?), Vector3? worldCenter = default(Vector3?), float? explosiveForce = default(float?))
		{
		}

		public void SetTransform(int idx, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		public void SetMaterial(int idx, Material newMaterial)
		{
		}

		public void EnableSound(int idx, float pitchMultiplier = 1f)
		{
		}

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDestroy()
		{
		}

		public SpawnFragment()
			: base()
		{
		}
	}
}
