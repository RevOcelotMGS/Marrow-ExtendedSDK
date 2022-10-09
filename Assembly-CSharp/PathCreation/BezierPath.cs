using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PathCreation
{
	[Serializable]
	public class BezierPath
	{
		public enum ControlMode
		{
			Aligned = 0,
			Mirrored = 1,
			Free = 2,
			Automatic = 3
		}

		[SerializeField]
		[HideInInspector]
		private List<Vector3> points;

		[SerializeField]
		[HideInInspector]
		private bool isClosed;

		[HideInInspector]
		[SerializeField]
		private PathSpace space;

		[SerializeField]
		[HideInInspector]
		private ControlMode controlMode;

		[SerializeField]
		[HideInInspector]
		private float autoControlLength;

		[SerializeField]
		[HideInInspector]
		private bool boundsUpToDate;

		[HideInInspector]
		[SerializeField]
		private Bounds bounds;

		[SerializeField]
		[HideInInspector]
		private List<float> perAnchorNormalsAngle;

		[SerializeField]
		[HideInInspector]
		private float globalNormalsAngle;

		[HideInInspector]
		[SerializeField]
		private bool flipNormals;

		public Vector3 this[int i]
		{
			get
			{
				return default(Vector3);
			}
		}

		public int NumPoints
		{
			get
			{
				return default(int);
			}
		}

		public int NumAnchorPoints
		{
			get
			{
				return default(int);
			}
		}

		public int NumSegments
		{
			get
			{
				return default(int);
			}
		}

		public PathSpace Space
		{
			get
			{
				return default(PathSpace);
			}
			set
			{
			}
		}

		public bool IsClosed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ControlMode ControlPointMode
		{
			get
			{
				return default(ControlMode);
			}
			set
			{
			}
		}

		public float AutoControlLength
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool FlipNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float GlobalNormalsAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Bounds PathBounds
		{
			get
			{
				return default(Bounds);
			}
		}

		public BezierPath(Vector3 centre, bool isClosed = false, PathSpace space = PathSpace.xyz)
			: base()
		{
		}

		public BezierPath(IEnumerable<Vector3> points, bool isClosed = false, PathSpace space = PathSpace.xyz)
			: base()
		{
		}

		public BezierPath(IEnumerable<Vector2> transforms, bool isClosed = false, PathSpace space = PathSpace.xy)
			: base()
		{
		}

		public BezierPath(IEnumerable<Transform> transforms, bool isClosed = false, PathSpace space = PathSpace.xy)
			: base()
		{
		}

		public BezierPath(IEnumerable<Vector2> points, PathSpace space = PathSpace.xyz, bool isClosed = false)
			: base()
		{
		}

		public Vector3 GetPoint(int i)
		{
			return default(Vector3);
		}

		public void SetPoint(int i, Vector3 localPosition, bool suppressPathModifiedEvent = false)
		{
		}

		public void AddSegmentToEnd(Vector3 anchorPos)
		{
		}

		public void AddSegmentToStart(Vector3 anchorPos)
		{
		}

		public void SplitSegment(Vector3 anchorPos, int segmentIndex, float splitTime)
		{
		}

		public void DeleteAllOtherAnchors(int keepIndex)
		{
		}

		public void DeleteSegment(int anchorIndex)
		{
		}

		public Vector3[] GetPointsInSegment(int segmentIndex)
		{
			return null;
		}

		public void MovePoint(int i, Vector3 pointPos, bool suppressPathModifiedEvent = false)
		{
		}

		public Bounds CalculateBoundsWithTransform(Transform transform)
		{
			return default(Bounds);
		}

		public float GetAnchorNormalAngle(int anchorIndex)
		{
			return default(float);
		}

		public void SetAnchorNormalAngle(int anchorIndex, float angle)
		{
		}

		public void ResetNormalAngles()
		{
		}

		private void UpdateBounds()
		{
		}

		private void AutoSetAllAffectedControlPoints(int updatedAnchorIndex)
		{
		}

		private void AutoSetAllControlPoints()
		{
		}

		private void AutoSetAnchorControlPoints(int anchorIndex)
		{
		}

		private void AutoSetStartAndEndControls()
		{
		}

		private void UpdateToNewPathSpace(PathSpace previousSpace)
		{
		}

		private void UpdateClosedState()
		{
		}

		private int LoopIndex(int i)
		{
			return default(int);
		}

		public void NotifyPathModified()
		{
		}

		public event Action OnModified;
	}
}
