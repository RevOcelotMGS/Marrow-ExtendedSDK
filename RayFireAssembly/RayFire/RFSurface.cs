using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFSurface
	{
		public Material innerMaterial;

		public float mappingScale;

		public Material outerMaterial;

		public bool needNewMat;

		public void CopyFrom(RFSurface interior)
		{
		}

		public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
		{
		}

		public static int SetInnerSubId(RayfireRigid scr)
		{
			return default(int);
		}

		public static int SetInnerSubId(RayfireShatter scr)
		{
			return default(int);
		}

		public RFSurface()
			: base()
		{
		}
	}
}
