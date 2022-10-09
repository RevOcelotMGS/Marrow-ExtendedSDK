using System.Collections.Generic;
using UnityEngine;

namespace SLZ.SceneStreaming
{
	public class DialogContainer : ScriptableObject
	{
		public List<NodeLinkData> NodeLinks;

		public List<DialogNodeData> DialogNodeData;

		public DialogContainer()
			: base()
		{
		}
	}
}
