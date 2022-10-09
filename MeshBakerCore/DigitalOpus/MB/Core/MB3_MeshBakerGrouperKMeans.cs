using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class MB3_MeshBakerGrouperKMeans : MB3_MeshBakerGrouperCore
	{
		public int numClusters;

		public Vector3[] clusterCenters;

		public float[] clusterSizes;

		public MB3_MeshBakerGrouperKMeans(GrouperData data)
			: base()
		{
		}

		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		public override void DrawGizmos(Bounds sceneObjectBounds)
		{
		}
	}
}
