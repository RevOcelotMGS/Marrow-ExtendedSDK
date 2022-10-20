using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace PathCreation.Examples
{
	public class RoadMeshCreator_Custom : PathSceneTool
	{
		[Header("Road settings")]
		public float roadWidth;

		[Range(0f, 0.5f)]
		public float thickness;

		public bool flattenSurface;

		[Header("Material settings")]
		public PhysicMaterial roadPhysMaterial;

		public Material roadMaterial;

		public Material undersideMaterial;

		public float textureTiling;

		public NavMeshSurface surface;

		[SerializeField]
		[HideInInspector]
		public GameObject meshHolder;

		private MeshFilter meshFilter;

		private MeshRenderer meshRenderer;

		private Mesh mesh;

		[Header("Chunk Section")]
		public RoadMeshCreator_Custom previousChunk;

		public RoadMeshCreator_Custom nextChunk;

		public RoadPartitionTrigger previousTrigger;

		public RoadPartitionTrigger nextTrigger;

		[HideInInspector]
		public VertexPath vpPartition;

		public Mesh MeshObj
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void TriggerNext()
		{
		}

		public void TriggerPrevious()
		{
		}

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
			throw new NotImplementedException();
		}

		public RoadMeshCreator_Custom()
			: base()
		{
		}

		public event Action NextTriggered;

		public event Action PreviousTriggered;
	}
}
