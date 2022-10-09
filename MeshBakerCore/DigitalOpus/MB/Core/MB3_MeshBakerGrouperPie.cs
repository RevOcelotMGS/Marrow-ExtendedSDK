using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public class MB3_MeshBakerGrouperPie : MB3_MeshBakerGrouperCore
	{
		public MB3_MeshBakerGrouperPie(GrouperData data)
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

		private static int MaxIndexInVector3(Vector3 v)
		{
			return default(int);
		}

		public static void DrawCircle(Vector3 axis, Vector3 center, float radius, int subdiv)
		{
		}
	}
}
