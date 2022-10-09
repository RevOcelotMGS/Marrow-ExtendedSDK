using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MB3_KMeansClustering
	{
		private class DataPoint
		{
			public Vector3 center;

			public GameObject gameObject;

			public int Cluster;

			public DataPoint(GameObject go)
				: base()
			{
			}
		}

		private List<DataPoint> _normalizedDataToCluster;

		private Vector3[] _clusters;

		private int _numberOfClusters;

		public MB3_KMeansClustering(List<GameObject> gos, int numClusters)
			: base()
		{
		}

		private void InitializeCentroids()
		{
		}

		private bool UpdateDataPointMeans(bool force)
		{
			return default(bool);
		}

		private bool AnyAreEmpty(List<DataPoint> data)
		{
			return default(bool);
		}

		private bool UpdateClusterMembership()
		{
			return default(bool);
		}

		private float ElucidanDistance(DataPoint dataPoint, Vector3 mean)
		{
			return default(float);
		}

		private int MinIndex(float[] distances)
		{
			return default(int);
		}

		public List<Renderer> GetCluster(int idx, [Out] Vector3 mean, [Out] float size)
		{
			return null;
		}

		public void Cluster()
		{
		}
	}
}
