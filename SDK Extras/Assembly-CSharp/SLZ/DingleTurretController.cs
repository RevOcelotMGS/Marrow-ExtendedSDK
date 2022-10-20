using UnityEngine;

namespace SLZ
{
	public class DingleTurretController : MonoBehaviour
	{
		public SplineBody splineBody;

		public TurretHeadController turret;

		public Transform testTarget;

		public float fireRate;

		private float _lastFireTime;

		private void Update()
		{
		}

		public DingleTurretController()
			: base()
		{
		}
	}
}
