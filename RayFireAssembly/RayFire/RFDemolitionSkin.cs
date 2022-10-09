using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFDemolitionSkin
	{
		public List<Transform> bones;

		public List<SkinnedMeshRenderer> skins;

		public List<SkinnedMeshRenderer> skins0;

		public List<SkinnedMeshRenderer> skins1;

		public List<SkinnedMeshRenderer> skins2;

		public void SetupSkin(RayfireRigid rigid)
		{
		}

		public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
		{
		}

		public RFDemolitionSkin()
			: base()
		{
		}
	}
}
