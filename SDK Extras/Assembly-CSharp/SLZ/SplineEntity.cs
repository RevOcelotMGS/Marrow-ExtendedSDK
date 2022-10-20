using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ
{
	public class SplineEntity : MonoBehaviour
	{
		public enum ContactCount
		{
			ONE = 1,
			TWO = 2,
			FOUR = 4
		}

		[Header("Configuration")]
		public ContactCount contactCount;

		public Vector3 axis;

		public Vector3 secondaryAxis;

		[SerializeField]
		protected Vector2 _size;

		public Vector3 anchor;

		[HideInInspector]
		public int lastSegmentIdx;

		[HideInInspector]
		public Vector3 lastPosition;

		public Quaternion AnchorRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 FrontContact
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 RightContact
		{
			get
			{
				return default(Vector3);
			}
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public SimpleTransform GetContactOriginInWorld()
		{
			return default(SimpleTransform);
		}

		public static Quaternion GetJointSpace(Vector3 priAxis, Vector3 secAxis)
		{
			return default(Quaternion);
		}

		private void OnDrawGizmosSelected()
		{
		}

		public SplineEntity()
			: base()
		{
		}
	}
}
