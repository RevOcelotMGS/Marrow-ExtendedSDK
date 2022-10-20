using System;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ
{
	[Serializable]
	public class SplineTimelineNode
	{
		public string name;

		public Color color;

		public bool oneShot;

		public UnityEvent nodeEvent;

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public SplineTimelineNode()
			: base()
		{
		}
	}
}
