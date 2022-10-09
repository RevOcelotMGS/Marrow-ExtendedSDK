using System.Runtime.InteropServices;
using UnityEngine;

namespace PuppetMasta
{
	public static class PhysXTools
	{
		public static void Predict(Rigidbody r, int steps, [Out] Vector3 position, [Out] Quaternion rotation)
		{
		}

		public static void Predict(Rigidbody r, int steps, [Out] Vector3 position, [Out] Quaternion rotation, Vector3 gravity, float drag, float angularDrag)
		{
		}

		public static void Predict(Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, Vector3 gravity, float drag, float angularDrag)
		{
		}

		public static Vector3 GetCenterOfMass(PuppetMaster puppet)
		{
			return default(Vector3);
		}

		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		public static void DivByInertia(Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		public static void ScaleByInertia(Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
}
