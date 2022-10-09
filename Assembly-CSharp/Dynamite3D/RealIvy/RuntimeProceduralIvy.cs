using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RuntimeProceduralIvy : RTIvy
	{
		private RuntimeIvyGrowth rtIvyGrowth;

		protected override void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		protected override void NextPoints(int branchIndex)
		{
		}

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
