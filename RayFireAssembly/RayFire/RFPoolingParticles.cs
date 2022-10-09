using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFPoolingParticles
	{
		public bool enable;

		[Range(1f, 500f)]
		public int capacity;

		[HideInInspector]
		public int poolRate;

		[HideInInspector]
		public ParticleSystem poolInstance;

		[HideInInspector]
		public Transform poolRoot;

		[HideInInspector]
		public List<ParticleSystem> poolList;

		[HideInInspector]
		public bool inProgress;

		public void CreatePoolRoot(Transform manTm)
		{
		}

		public void CreateInstance(Transform manTm)
		{
		}

		public static ParticleSystem CreateParticleInstance()
		{
			return null;
		}

		public ParticleSystem GetPoolObject(Transform manTm)
		{
			return null;
		}

		private ParticleSystem CreatePoolObject(Transform manTm)
		{
			return null;
		}

		public IEnumerator StartPoolingCor(Transform manTm)
		{
			return null;
		}

		public RFPoolingParticles()
			: base()
		{
		}
	}
}
