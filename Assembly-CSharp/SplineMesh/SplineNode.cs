using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SplineMesh
{
	[Serializable]
	public class SplineNode
	{
		[SerializeField]
		private Vector3 position;

		[SerializeField]
		private Vector3 direction;

		[SerializeField]
		private Vector3 up;

		[SerializeField]
		private Vector2 scale;

		[SerializeField]
		private float roll;

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Direction
		{
			get
			{
				return default(Vector3);
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
			set
			{
			}
		}

		public Vector2 Scale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float Roll
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public SplineNode(Vector3 position, Vector3 direction)
			: base()
		{
		}

		public event EventHandler Changed;
	}
}
