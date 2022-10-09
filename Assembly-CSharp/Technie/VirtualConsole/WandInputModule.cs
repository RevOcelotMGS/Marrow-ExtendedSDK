using UnityEngine;
using UnityEngine.EventSystems;

namespace Technie.VirtualConsole
{
	public class WandInputModule : BaseInputModule
	{
		public static WandInputModule Instance;

		[Header(" [Cursor setup]")]
		public Sprite CursorSprite;

		public Material CursorMaterial;

		public float NormalCursorScale;

		[Space(10f)]
		[Header(" [Runtime variables]")]
		[Tooltip("Indicates whether or not the gui was hit by any controller this frame")]
		public bool guiHit;

		[Tooltip("Indicates whether or not a button was used this frame")]
		public bool ButtonUsed;

		[Tooltip("Generated cursors")]
		public RectTransform[] Cursors;

		[Tooltip("Generated non rendering camera (used for raycasting ui)")]
		public Camera ControllerCamera;

		public Color[] cursorColours;

		public bool ignoreOverlayCanvases;

		private Transform[] raycastOrigin;

		private bool[] raycastActive;

		private GameObject[] CurrentPoint;

		private GameObject[] CurrentPressed;

		private GameObject[] CurrentDragging;

		private Vector3[] CurrentRaycastPosition;

		private Ray[] LastRays;

		private PointerEventData[] PointEvents;

		private bool[] latchedDownEdges;

		private bool[] latchedUpEdges;

		private bool Initialized;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void OnHandsDetected(HandAbstraction hands)
		{
		}

		public void SetRaycastOrigins(Transform leftOrigin, Transform rightOrigin)
		{
		}

		public void SetRaycastActive(HandType hand, bool isActive)
		{
		}

		private void Initialise()
		{
		}

		public Camera GetControllerCamera()
		{
			return null;
		}

		private bool GetLookPointerEventData(int index)
		{
			return default(bool);
		}

		private static Canvas FindParentCanvas(GameObject obj)
		{
			return null;
		}

		private void UpdateCursor(int index, PointerEventData pointData)
		{
		}

		public void ClearSelection()
		{
		}

		private void Select(GameObject go)
		{
		}

		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		private void UpdateCameraPosition(int index)
		{
		}

		public override void Process()
		{
		}

		private bool ButtonDown(int index)
		{
			return default(bool);
		}

		private bool ButtonUp(int index)
		{
			return default(bool);
		}

		public void LatchButtonDown(int index)
		{
		}

		public void LatchButtonUp(int index)
		{
		}

		public bool HasCurrentPointTarget(int index)
		{
			return default(bool);
		}

		public Vector3 GetCurrentPointPosition(int index)
		{
			return default(Vector3);
		}

		public bool HasLeftPointTarget()
		{
			return default(bool);
		}

		public bool HasRightPointTarget()
		{
			return default(bool);
		}

		public void SetCursorsVisible(bool visible)
		{
		}

		public WandInputModule()
			: base()
		{
		}
	}
}
