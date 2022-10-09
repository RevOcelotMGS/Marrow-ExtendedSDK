using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RuntimeBakedIvy : RTIvy
	{
		public override bool IsGrowingFinished()
		{
			return default(bool);
		}

		private void CalculateLifetime()
		{
		}

		protected override float GetNormalizedLifeTime()
		{
			return default(float);
		}

		protected override int GetMaxNumPoints()
		{
			return default(int);
		}

		protected override int GetMaxNumLeaves()
		{
			return default(int);
		}

		public void InitIvyEditor(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		public RuntimeBakedIvy()
			: base()
		{
		}
	}
}
