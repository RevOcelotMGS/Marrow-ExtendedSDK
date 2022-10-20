using UnityEngine;

namespace PathCreation.Examples
{
	public class RoadMeshCreator : PathSceneTool
	{
		[Header("Road settings")]
		public float roadWidth;

		public float thickness;

		public bool flattenSurface;

		[Header("Material settings")]
		public Material roadMaterial;

		public Material undersideMaterial;

		public float textureTiling;

		[SerializeField]
		[HideInInspector]
		public GameObject meshHolder;

		private MeshFilter meshFilter;

		private MeshRenderer meshRenderer;

		private Mesh mesh;

		private string assetPath;

		private void CreateRoadMesh()
		{
		}

		private void AssignMeshComponents()
		{
		}

		private void AssignMaterials()
		{
		}

		protected override void PathUpdated() {
			throw new System.NotImplementedException();
		}

		public RoadMeshCreator()
			: base()
		{
		}
	}
}
