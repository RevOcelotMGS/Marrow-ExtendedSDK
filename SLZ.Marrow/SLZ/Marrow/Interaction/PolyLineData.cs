using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public class PolyLineData : ScriptableObject
	{
		[Serializable]
		public enum SegmentResolution
		{
			Millimeter = 0,
			Centimeter = 1,
			Decimeter = 2,
			Meter = 3
		}

		[SerializeField]
		public SegmentResolution segmentResolution;

		[SerializeField]
		public PolyLineVert[] polyVerts;

		[SerializeField]
		public float totalDistance;

		public float SegmentDistance()
		{
			return default(float);
		}

		public PolyLineData()
			: base()
		{
		}
	}
}
