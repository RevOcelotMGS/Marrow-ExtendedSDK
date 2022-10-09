using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace RayFire
{
	[Serializable]
	public class RFParticleRendering
	{
		[Header("  Shadows")]
		[Space(3f)]
		public bool castShadows;

		[Space(2f)]
		public bool receiveShadows;

		[Space(2f)]
		[Space(3f)]
		[Header("  Light")]
		public LightProbeUsage lightProbes;

		public void CopyFrom(RFParticleRendering source)
		{
		}

		public RFParticleRendering()
			: base()
		{
		}
	}
}
