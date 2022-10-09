using System;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFRigidRootDemolition
	{
		[Space(2f)]
		public RFLimitations limitations;

		[Space(2f)]
		public RFDemolitionCluster clusterDemolition;

		public RFRigidRootDemolition()
			: base()
		{
		}
	}
}
