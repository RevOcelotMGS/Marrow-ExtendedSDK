using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace ECE
{
	public class EasyColliderQuickHull
	{
		private class Face
		{
			public int F0;

			public int F1;

			public int F2;

			public Vector3 Normal;

			public bool OnConvexHull;

			public List<int> OutsideVertices;

			public int V0;

			public int V1;

			public int V2;

			public Face(int v0, int v1, int v2, Vector3 normal, int f0, int f1, int f2)
				: base()
			{
			}
		}

		private class Horizon
		{
			public int Face;

			public int From;

			public bool OnConvexHull;

			public int V0;

			public int V1;

			public Horizon(int v0, int v1, int face, int from)
				: base()
			{
			}
		}

		public bool DebugHorizon;

		public Color DebugHorizonColor;

		public int DebugLoopNumber;

		public int DebugMaxLoopNumber;

		public bool DebugNewFaces;

		public bool DebugNormals;

		public bool DebugOutsideSet;

		public Color DebugNormalColor;

		public float DrawTime;

		private HashSet<int> AssignedVertices;

		private HashSet<int> ClosedVertices;

		private List<Horizon> CurrentHorizon;

		private float Epsilon;

		private List<Face> Faces;

		private List<int> NewFaces;

		public Mesh Result;

		private HashSet<int> UnAssignedVertices;

		private List<Vector3> VerticesList;

		public bool isFinished
		{
			get
			{
				return default(bool);
			}
		}

		public static EasyColliderQuickHull CalculateHull(List<Vector3> points)
		{
			return null;
		}

		public static EasyColliderQuickHull CalculateHullWorld(List<Vector3> points, Transform attachTo)
		{
			return null;
		}

		public static MeshColliderData CalculateHullData(List<Vector3> points, Transform attachTo)
		{
			return null;
		}

		public static MeshColliderData CalculateHullData(List<Vector3> points)
		{
			return null;
		}

		private void AddToOutsideSet(Face face, HashSet<int> vertices)
		{
		}

		private bool AreVertsCoincident(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		private bool AreVertsCoincident(int a, int b)
		{
			return default(bool);
		}

		private void CloseUnAssignedVertsOnFaces()
		{
		}

		private bool IsVertOnFace(int i, Face face)
		{
			return default(bool);
		}

		private Vector3 CalcNormal(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		private Vector3 CalcNormal(int a, int b, int c)
		{
			return default(Vector3);
		}

		private float CalcTriangleArea(int v0, int v1, int v2)
		{
			return default(float);
		}

		private void CalculateHorizon(int eyePoint, Horizon crossedEdge, int currFace, bool firstFace = true)
		{
		}

		private Mesh CreateMesh(List<Face> allFaces)
		{
			return null;
		}

		private float DistanceFromLine(Vector3 point, Vector3 line, Vector3 pointOnLine)
		{
			return default(float);
		}

		private float DistanceFromPlane(Vector3 point, Plane p)
		{
			return default(float);
		}

		private float DistanceFromPlane(Vector3 point, Vector3 normal, Vector3 pointOnPlane)
		{
			return default(float);
		}

		private bool FindInitialHull(List<Vector3> points)
		{
			return default(bool);
		}

		private bool FindInitialPointsFallBack(List<Vector3> points, [Out] List<int> initialPoints)
		{
			return default(bool);
		}

		private bool FindInitialPoints(List<Vector3> points, [Out] List<int> initialPoints)
		{
			return default(bool);
		}

		private void CalculateEpsilon(List<Vector3> points)
		{
		}

		public void GenerateHull(List<Vector3> points)
		{
		}

		private int GetFurthestPointFromFace(int faceIndex)
		{
			return default(int);
		}

		private int GetNonEmptyFaceIndex()
		{
			return default(int);
		}

		private bool HaveNonEmptyFaceSet()
		{
			return default(bool);
		}

		private bool isAGreaterThanB(float a, float b)
		{
			return default(bool);
		}

		private bool isALessThanB(float a, float b)
		{
			return default(bool);
		}

		private bool isApproxEqual(float a, float b)
		{
			return default(bool);
		}

		private bool IsApproxZero(float a)
		{
			return default(bool);
		}

		private void UpdateFace(Horizon horizon, int newFace)
		{
		}

		private Vector3 CalcFaceCenter(Face face)
		{
			return default(Vector3);
		}

		private void DebugInitialPoints(List<Vector3> points, List<int> initialPoints)
		{
		}

		private void DrawFace(int face, Color color, float size = 0.08f)
		{
		}

		private void DrawFaceConnections(int face)
		{
		}

		private void DrawFaceNormal(Face face, Color color, float distance = 1f)
		{
		}

		private void ForceUpdateFace(int faceIndex)
		{
		}

		private Color RandomColor()
		{
			return default(Color);
		}

		private void DrawPoint(Vector3 point, Color color, float size = 0.05f)
		{
		}

		public EasyColliderQuickHull()
			: base()
		{
		}
	}
}
