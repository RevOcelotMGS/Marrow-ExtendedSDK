using System;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public struct RTVertexData
	{
		public Vector3 vertex;

		public Vector3 normal;

		public Vector2 uv;

		public Vector2 uv2;

		public Color color;

		public RTVertexData(Vector3 vertex, Vector3 normal, Vector2 uv, Vector2 uv2, Color color)
		{
			this.color = default(Color);
			this.uv2 = default(Vector2);
			this.uv = default(Vector2);
			this.normal = default(Vector3);
			this.vertex = default(Vector3);
		}
	}
}
