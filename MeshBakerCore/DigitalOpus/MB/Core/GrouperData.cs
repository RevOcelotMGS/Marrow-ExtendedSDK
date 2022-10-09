using System;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class GrouperData
	{
		public bool clusterOnLMIndex;

		public bool clusterByLODLevel;

		public Vector3 origin;

		public Vector3 cellSize;

		public int pieNumSegments;

		public Vector3 pieAxis;

		public float ringSpacing;

		public bool combineSegmentsInInnermostRing;

		public int height;

		public float maxDistBetweenClusters;

		public bool includeCellsWithOnlyOneRenderer;

		public GrouperData()
			: base()
		{
		}
	}
}
