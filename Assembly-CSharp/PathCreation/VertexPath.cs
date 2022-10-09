using System;
using System.Runtime.InteropServices;
using PathCreation.Utility;
using UnityEngine;

namespace PathCreation
{
	[Serializable]
	public class VertexPath
	{
		public struct TimeOnPathData
		{
			public readonly int previousIndex;

			public readonly int nextIndex;

			public readonly float percentBetweenIndices;

			public TimeOnPathData(int prev, int next, float percentBetweenIndices)
			{
				this.percentBetweenIndices = default(float);
				this.nextIndex = default(int);
				this.previousIndex = default(int);
			}
		}

		[SerializeField]
		private PathSpace space;

		[SerializeField]
		private bool isClosedLoop;

		[SerializeField]
		private Vector3[] localPoints;

		[SerializeField]
		private Vector3[] localTangents;

		[SerializeField]
		private Vector3[] localNormals;

		[SerializeField]
		private float[] times;

		[SerializeField]
		private float length;

		[SerializeField]
		private float[] cumulativeLengthAtEachVertex;

		[SerializeField]
		private readonly Bounds bounds;

		[SerializeField]
		private readonly Vector3 up;

		[SerializeField]
		private const int accuracy = 10;

		[SerializeField]
		private const float minVertexSpacing = 0.01f;

		[SerializeField]
		private bool ignoreClosedLoop;

		[SerializeField]
		private Transform transform;

		public PathSpace Space
		{
			get
			{
				return default(PathSpace);
			}
		}

		public bool IsClosedLoop
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3[] LocalPoints
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3[] LocalTangents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3[] LocalNormals
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float[] Times
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Length
		{
			get
			{
				return default(float);
			}
		}

		public float[] CumulativeLengthAtEachVertex
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool IgnoreClosedLoop
		{
			get
			{
				return default(bool);
			}
		}

		public int NumPoints
		{
			get
			{
				return default(int);
			}
		}

		public VertexPath(BezierPath bezierPath, Transform transform, float maxAngleError = 0.3f, float minVertexDst = 0f, bool ignoreClosed = false)
			: base()
		{
		}

		public VertexPath(BezierPath bezierPath, Transform transform, float vertexSpacing, bool ignoreClosed = false, bool partitionMode = false, float maxTrackTwist = 1f)
			: base()
		{
		}

		public VertexPath(VertexPath masterPath, int partitionInd, float pointsPerPartition, bool continuousTrack, bool ignoreClosed = false, bool isLastPart = false, Transform partTransform = default(Transform))
			: base()
		{
		}

		public VertexPath(BezierPath bezierPath, VertexPathUtility.PathSplitData pathSplitData, Transform transform, bool ignoreClosed = false, bool partitionMode = false, float maxTwist = 1f)
			: base()
		{
		}

		public void UpdateTransform(Transform transform)
		{
		}

		public Vector3 GetTangent(int index)
		{
			return default(Vector3);
		}

		public Vector3 GetNormal(int index)
		{
			return default(Vector3);
		}

		public Vector3 GetPoint(int index)
		{
			return default(Vector3);
		}

		public Vector3 GetPointAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		public Vector3 GetDirectionAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		public Vector3 GetNormalAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		public Quaternion GetRotationAtDistance(float dst, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Quaternion);
		}

		public Vector3 GetPointAtTime(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		public Vector3 GetDirection(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		public Vector3 GetNormal(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Vector3);
		}

		public Quaternion GetRotation(float t, EndOfPathInstruction endOfPathInstruction = EndOfPathInstruction.Loop)
		{
			return default(Quaternion);
		}

		public Vector3 GetClosestPointOnPath(Vector3 worldPoint)
		{
			return default(Vector3);
		}

		public float GetClosestTimeOnPath(Vector3 worldPoint)
		{
			return default(float);
		}

		public float GetClosestDistanceAlongPath(Vector3 worldPoint)
		{
			return default(float);
		}

		private TimeOnPathData CalculatePercentOnPathData(float t, EndOfPathInstruction endOfPathInstruction)
		{
			return default(TimeOnPathData);
		}

		private TimeOnPathData CalculateClosestPointOnPathData(Vector3 worldPoint)
		{
			return default(TimeOnPathData);
		}
	}
}
