using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-combine-component/")]
	[AddComponentMenu("RayFire/Rayfire Combine")]
	public class RayfireCombine : MonoBehaviour
	{
		public enum CombType
		{
			Children = 0,
			ObjectsList = 1
		}

		public CombType type;

		public List<GameObject> objects;

		public bool meshFilters;

		public bool skinnedMeshes;

		public bool particleSystems;

		public float sizeThreshold;

		public int vertexThreshold;

		private Transform transForm;

		private MeshFilter mFilter;

		private MeshRenderer mRenderer;

		private List<bool> invertNormals;

		private List<Transform> transList;

		private List<MeshFilter> mFilters;

		private List<SkinnedMeshRenderer> skinnedMeshRends;

		private List<ParticleSystemRenderer> particleRends;

		private List<Mesh> meshList;

		private List<List<int>> matIdList;

		private List<List<Material>> matList;

		private List<Material> allMaterials;

		public void Combine()
		{
		}

		private bool SetData()
		{
			return default(bool);
		}

		public RayfireCombine()
			: base()
		{
		}
	}
}
