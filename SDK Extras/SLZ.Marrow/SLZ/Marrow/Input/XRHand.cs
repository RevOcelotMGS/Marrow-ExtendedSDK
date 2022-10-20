using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class XRHand : XRDevice
	{
		protected bool _isFullUpdate;

		public Quaternion[] Rotations { get; protected set; }

		public Vector3[] Positions { get; protected set; }

		public float[] Radii { get; protected set; }

		public float ThumbCurl { get; protected set; }

		public float IndexCurl { get; protected set; }

		public float MiddleCurl { get; protected set; }

		public float RingCurl { get; protected set; }

		public float PinkyCurl { get; protected set; }

		public void StopFullUpdate()
		{
		}

		public void StartFullUpdate()
		{
		}

		public SimpleTransform GetHandBone(XRHand hand, HandBone bone)
		{
			return default(SimpleTransform);
		}

		public XRHand()
			: base()
		{
		}
	}
}
