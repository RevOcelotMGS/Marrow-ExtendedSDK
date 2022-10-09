using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	public abstract class MB3_MeshBakerGrouperCore
	{
		public GrouperData d;

		public abstract Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection);

		public abstract void DrawGizmos(Bounds sourceObjectBounds);

		public List<MB3_MeshBakerCommon> DoClustering(MB3_TextureBaker tb, MB3_MeshBakerGrouper grouper)
		{
			return null;
		}

		private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
		{
			return null;
		}

		private MB3_MeshBakerCommon AddMeshBaker(MB3_MeshBakerGrouper grouper, MB3_TextureBaker tb, string key, List<Renderer> gaws)
		{
			return null;
		}

		public MB3_MeshBakerGrouperCore()
			: base()
		{
		}
	}
}
