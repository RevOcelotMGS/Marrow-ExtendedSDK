using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFPoolingFragment
	{
		public bool enable;

		[Range(1f, 500f)]
		public int capacity;

		public int poolRate;

		public RayfireRigid poolInstance;

		public Transform poolRoot;

		public List<RayfireRigid> poolList;

		public bool inProgress;

		public void CreatePoolRoot(Transform manTm)
		{
		}

		public void CreateInstance(Transform manTm)
		{
		}

		public static RayfireRigid CreateRigidInstance()
		{
			return null;
		}

		public RayfireRigid GetPoolObject(Transform manTm)
		{
			return null;
		}

		private RayfireRigid CreatePoolObject(Transform manTm)
		{
			return null;
		}

		public IEnumerator StartPoolingCor(Transform manTm)
		{
			return null;
		}

		public RFPoolingFragment()
			: base()
		{
		}
	}
}
