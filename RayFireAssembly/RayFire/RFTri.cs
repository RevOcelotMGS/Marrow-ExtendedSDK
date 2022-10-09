using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	public class RFTri
	{
		public int meshId;

		public int subMeshId;

		public List<int> ids;

		public List<Vector3> vpos;

		public List<Vector3> vnormal;

		public List<Vector2> uvs;

		public List<Vector4> tangents;

		public List<RFTri> neibTris;

		public RFTri()
			: base()
		{
		}
	}
}
