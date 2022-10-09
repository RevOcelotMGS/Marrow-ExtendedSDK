using UnityEngine;
using UnityEngine.UI;

namespace Technie.VirtualConsole
{
	public class VrDebugDisplay : MonoBehaviour
	{
		public enum State
		{
			Collapsed = 0,
			NormalSize = 1,
			LargeSize = 2
		}

		public Canvas mainCanvas;

		public Canvas collapsedCanvas;

		public HandType handType;

		public Transform center;

		public Transform panelAttach;

		public float panelScale;

		public Text titleText;

		public Text maximiseText;

		public PanelManager panelManager;

		[ReadOnly]
		public GameObject targetHand;

		[ReadOnly]
		public Camera eventCamera;

		private State state;

		private State prevState;

		private DebugPanel attachedPanel;

		private bool disableCanvasWhenNotInView;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void TrackTargetHand()
		{
		}

		public void AllowDisableCanvasWhenNotInView(bool allow)
		{
		}

		public void OnToggleSize()
		{
		}

		public void OnCollapse()
		{
		}

		public void OnRestore()
		{
		}

		public void OnNextPanel()
		{
		}

		public void OnPrevPanel()
		{
		}

		public float DistanceTo(Vector3 worldPosition)
		{
			return default(float);
		}

		public Vector3 FindClosestPoint(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		private Vector3 ClosestPoint(Vector3 worldPosition, Canvas canvas, Vector2 canvasSize)
		{
			return default(Vector3);
		}

		public void Attach(DebugPanel newPanel)
		{
		}

		public void SetDisplayVisible(bool visible)
		{
		}

		public VrDebugDisplay()
			: base()
		{
		}
	}
}
