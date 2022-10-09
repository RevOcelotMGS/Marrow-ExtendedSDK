using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class MB3_MeshBakerGrouperNone : MB3_MeshBakerGrouperCore
	{
		public MB3_MeshBakerGrouperNone(GrouperData d)
			: base()
		{
		}

		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		public override void DrawGizmos(Bounds sourceObjectBounds)
		{
		}
	}
}
