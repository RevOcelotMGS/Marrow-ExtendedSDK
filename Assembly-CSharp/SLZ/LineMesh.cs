using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace SLZ
{
	public class LineMesh : MonoBehaviour
	{
		private static LineMesh _inst;

		private DrawLineCommand[] _commands;

		private int _commandsIndex;

		private Mesh _linesMesh;

		private Vector3[] _linesVerticies;

		private Color[] _linesColors;

		private int[] _linesIndicies;

		private int _lastVertLength;

		public Material lineMaterial;

		private void Awake()
		{
		}

		private static void Initialize()
		{
		}

		private static void Uninitialize()
		{
		}

		public static void DrawLine(Vector3 startPos, Vector3 endPos, Color color, float duration = 0f)
		{
		}

		public static void DrawLine(Vector3 startPos, Vector3 endPos, Color color, float time, float duration)
		{
		}

		public static void DrawTransform(Vector3 position, Quaternion rotation, float duration = 0f)
		{
		}

		public static void DrawTransform(RigidTransform t, float duration = 0f)
		{
		}

		public static void DrawBox(Vector3 position, Quaternion rotation, Vector3 halfExtends, Color color = default(Color), float duration = 0f)
		{
		}

		public static void DrawCircle(Vector3 position, Vector3 normal, float radius, Color color, int segments = 16, float duration = 0f)
		{
		}

		public static void DrawConfigJoint(ConfigurableJoint joint, Quaternion startRotation)
		{
		}

		private static void DrawJointAnchor(SimpleTransform anchorT, float scale)
		{
		}

		public void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public LineMesh()
			: base()
		{
		}
	}
}
