using System;
using UnityEngine;

namespace SLZ.SceneStreaming
{
	[Serializable]
	public class NodeLinkData : MonoBehaviour
	{
		public string BaseNodeGuid;

		public string PortName;

		public string TargetNodeGuid;

		public NodeLinkData()
			: base()
		{
		}
	}
}
