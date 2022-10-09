using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFCache
	{
		public string name;

		public List<bool> act;

		public List<Vector3> pos;

		public List<Quaternion> rot;

		public Transform transform;

		public RFCache(Transform parent, Transform tm)
			: base()
		{
		}
	}
}
