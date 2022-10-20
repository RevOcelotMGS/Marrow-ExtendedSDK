using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ
{
	public class SplineBody : SplineEntity
	{
		private static ComponentCache<SplineBody> _cache;

		public ConfigurableJointMotion angularXMotion;

		public float angularXLimit;

		public float angularXLimitBounciness;

		public float angularXLimitContactDistance;

		[Header("References")]
		public Rigidbody rb;

		public float targetVelocity;

		public float positionDamper;

		public float maximumForce;

		[HideInInspector]
		public ConfigurableJoint[] contactJoints;

		[HideInInspector]
		public bool isSpeedChanged;

		public static ComponentCache<SplineBody> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		public void SetTargetVelocity(float velocity)
		{
		}

		public void SetPositionDamper(float damper)
		{
		}

		public void SetMaximumForce(float force)
		{
		}

		public SplineBody()
			: base()
		{
		}
	}
}
