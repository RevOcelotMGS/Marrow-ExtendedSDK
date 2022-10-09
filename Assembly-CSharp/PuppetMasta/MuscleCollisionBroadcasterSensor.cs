using System.Runtime.InteropServices;
using UnityEngine;

namespace PuppetMasta
{
	public class MuscleCollisionBroadcasterSensor : MuscleCollisionBroadcaster
	{
		public bool isGrounded;

		public Vector3 groundNormal;

		public Vector3 _totalImpulse;

		public float totalMass;

		public float additionalMass;

		private Vector3 _deltaVel;

		private Vector3 _groundVel;

		private Vector3 _lastGroundVel;

		private float _groundMultSum;

		private float _groundAngVel;

		private int _count;

		private Rigidbody _rb;

		private int collisionLayer;

		private void Start()
		{
		}

		private void OnCollisionStay(Collision collision)
		{
		}

		private void ProcessCollision(Collision c)
		{
		}

		public void ReadData([Out] Vector3 deltaPosition, [Out] Vector3 impulse, [Out] bool asleep)
		{
		}

		public void ReadData([Out] Vector3 deltaPosition, [Out] Vector3 impulse, [Out] bool asleep, [Out] Vector3 groundVelocity, [Out] float groundAngVel)
		{
		}

		public MuscleCollisionBroadcasterSensor()
			: base()
		{
		}
	}
}
