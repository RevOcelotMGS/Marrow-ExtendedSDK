using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RuntimeProceduralIvy : RTIvy
	{
		private RuntimeIvyGrowth rtIvyGrowth;

		public override bool IsGrowingFinished()
		{
			return default(bool);
		}

		protected override float GetNormalizedLifeTime()
		{
			return default(float);
		}

		public void SetIvyParameters(IvyPreset ivyPreset)
		{
		}

		protected override int GetMaxNumPoints()
		{
			return default(int);
		}

		protected override int GetMaxNumLeaves()
		{
			return default(int);
		}

		private int GetMaxNumVerticesPerLeaf()
		{
			return default(int);
		}

		public RuntimeProceduralIvy()
			: base()
		{
		}
	}
}
