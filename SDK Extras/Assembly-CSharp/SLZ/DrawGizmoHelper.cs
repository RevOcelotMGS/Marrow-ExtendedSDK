using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ
{
	public class DrawGizmoHelper
	{
		public enum ArrowType
		{
			Default = 0,
			Double = 1
		}

		public static void Cone(Vector3 point, float distance, float angle)
		{
		}

		public static void Arrow(Vector3 start, Vector3 end, Vector3 normal = default(Vector3), ArrowType type = ArrowType.Default, float arrowHeadLength = 0.2f, float arrowHeadAngle = 30f)
		{
		}

		public DrawGizmoHelper()
			: base()
		{
		}
	}
}
