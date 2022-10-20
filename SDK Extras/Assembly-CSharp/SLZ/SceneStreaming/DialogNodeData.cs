using System;
using UnityEngine;

namespace SLZ.SceneStreaming
{
	[Serializable]
	public class DialogNodeData
	{
		public string Guid;

		public string DialogText;

		public Vector2 Position;

		public DialogNodeData()
			: base()
		{
		}
	}
}
