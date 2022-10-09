using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class Contact
	{
		private static readonly float CONTACT_UPDATE_DISTANCE_SQR;

		private readonly Rigidbody _rigidbody;

		private readonly Rigidbody _hostBody;

		private readonly ConfigurableJoint _joint;

		private readonly Vector3 _anchorPosition;

		private readonly quaternion _anchorRotation;

		private readonly quaternion _startRotation;

		private readonly quaternion _worldToJointSpace;

		public SimpleTransform Transform
		{
			get
			{
				return default(SimpleTransform);
			}
		}

		public Contact(Rigidbody hostBody, Vector3 anchorPosition, Quaternion anchorRotation, ConfigurableJointMotion twistMotion = ConfigurableJointMotion.Free, float twistMinLimit = 0f, float twistMaxLimit = 0f, ConfigurableJointMotion swingMotion = ConfigurableJointMotion.Free, float swingLimit = 0f, SplineJointMotion linearYZMotion = SplineJointMotion.Locked, float limit = 0f, float bounciness = 0f, float contactDistance = 0f)
			: base()
		{
		}

		public void Destroy()
		{
		}

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		public void LimitDirection(float limit, bool isForward = true)
		{
		}

		public void FreeDirection()
		{
		}

		public void SwingTwistSpringStabilization()
		{
		}

		public void WakeUp()
		{
		}

		public void SetAngularXDriveSpeed(float speed)
		{
		}

		public void SetAngularXDrivePositionSpring(float springForce)
		{
		}

		public void SetAngularXDrivePositionDamper(float damperForce)
		{
		}

		public void SetAngularXDriveMaxForce(float maximumForce)
		{
		}

		public void SetAngularYZDrivePositionSpring(float springForce)
		{
		}

		public void SetAngularYZDrivePositionDamper(float damperForce)
		{
		}

		public void SetAngularYZDriveMaxForce(float maximumForce)
		{
		}

		public void SetLinearXDriveSpeed(float speed)
		{
		}

		public void SetLinearXDrivePositionDamper(float damperForce)
		{
		}

		public void SetLinearXDriveMaxForce(float maximumForce)
		{
		}

		public void SetLinearYZDrivePositionSpring(float springForce)
		{
		}

		public void SetLinearYZDrivePositionDamper(float damperForce)
		{
		}

		public void SetLinearYZDriveMaxForce(float maximumForce)
		{
		}
	}
}
