using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SplineMesh
{
	public struct SourceMesh
	{
		private Vector3 translation;

		private Quaternion rotation;

		private Vector3 scale;

		private List<MeshVertex> vertices;

		private int[] triangles;

		private float minX;

		private float length;

		internal Mesh Mesh
		{
			get;
		}

		internal List<MeshVertex> Vertices
		{
			get
			{
				return null;
			}
		}

		internal int[] Triangles
		{
			get
			{
				return null;
			}
		}

		internal float MinX
		{
			get
			{
				return default(float);
			}
		}

		internal float Length
		{
			get
			{
				return default(float);
			}
		}

		private SourceMesh(Mesh mesh)
		{
			this.Mesh = default(Mesh);
			this.length = default(float);
			this.minX = default(float);
			this.triangles = default(int[]);
			this.vertices = default(List<MeshVertex>);
			this.scale = default(Vector3);
			this.rotation = default(Quaternion);
			this.translation = default(Vector3);
		}

		private SourceMesh(SourceMesh other)
		{
			this.Mesh = default(Mesh);
			this.length = default(float);
			this.minX = default(float);
			this.triangles = default(int[]);
			this.vertices = default(List<MeshVertex>);
			this.scale = default(Vector3);
			this.rotation = default(Quaternion);
			this.translation = default(Vector3);
		}

		public static SourceMesh Build(Mesh mesh)
		{
			return default(SourceMesh);
		}

		public SourceMesh Translate(Vector3 translation)
		{
			return default(SourceMesh);
		}

		public SourceMesh Translate(float x, float y, float z)
		{
			return default(SourceMesh);
		}

		public SourceMesh Rotate(Quaternion rotation)
		{
			return default(SourceMesh);
		}

		public SourceMesh Scale(Vector3 scale)
		{
			return default(SourceMesh);
		}

		public SourceMesh Scale(float x, float y, float z)
		{
			return default(SourceMesh);
		}

		private void BuildData()
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool operator ==(SourceMesh sm1, SourceMesh sm2)
		{
			return default(bool);
		}

		public static bool operator !=(SourceMesh sm1, SourceMesh sm2)
		{
			return default(bool);
		}
	}
}
