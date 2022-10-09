using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFStorage
	{
		public List<Transform> storageList;

		public Transform storageRoot;

		public bool inProgress;

		private float rate;

		public void CreateStorageRoot(Transform manTm)
		{
		}

		public IEnumerator StorageCor()
		{
			return null;
		}

		public void Register(Transform tm)
		{
		}

		public void DestroyAll()
		{
		}

		public RFStorage()
			: base()
		{
		}
	}
}
