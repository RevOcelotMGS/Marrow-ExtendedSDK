using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class RifleVirtualController : VirtualControllerOverride
	{
		public Transform shoulderTransform;

		public float maxDistance;

		public float rotationMult;

		public float positionMult;

		private float _lastX;

		private float _lastTime;

		private Vector2 _lastTt;

		private bool _resetX;

		private bool _secIsLead;

		private bool _firstPass;

		private SimpleTransform _buttInRig;

		private SimpleTransform _hostOffset;

		private SimpleTransform _lastBlendTransform;

		private SimpleTransform _lastVcInLocal;

		private Vector3 _acceleration;

		private Vector3 _velocity;

		protected void Reset()
		{
		}

		private Vector2 ShoulderPoint(Vector3 shoulderLf, Vector3 shoulderRt, Vector3 butt, Vector3 sacrum)
		{
			return default(Vector2);
		}

		private Vector3 CalcShoulder(Vector3 shoulderLf, Vector3 shoulderRt, Vector3 sacrum, Vector2 tt)
		{
			return default(Vector3);
		}

		public override void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}

		public RifleVirtualController()
			: base()
		{
		}
	}
}
