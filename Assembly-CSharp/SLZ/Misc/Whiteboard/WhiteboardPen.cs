using UnityEngine;

namespace SLZ.Misc.Whiteboard
{
	public class WhiteboardPen : MonoBehaviour
	{
		public Color color;

		public float radius;

		public float featherRadius;

		public Collider penCollider;

		public Transform penTip;

		public bool isEraser;

		private void Start()
		{
		}

		public WhiteboardPen()
			: base()
		{
		}
	}
}
