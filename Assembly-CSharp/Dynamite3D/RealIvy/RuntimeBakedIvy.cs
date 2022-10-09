using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RuntimeBakedIvy : RTIvy
	{
		public override bool IsGrowingFinished()
		{
			return default(bool);
		}

		protected override void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		private void CalculateLifetime()
		{
		}

		protected override float GetNormalizedLifeTime()
		{
			return default(float);
		}

		protected override void InitializeMeshesData(Mesh bakedMesh, int numBranches)
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

		public override void InitIvy(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
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
