using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class MeshCombiner : MonoBehaviour
{
	private const int Mesh16BitBufferVertexLimit = default(int);

	[SerializeField]
	private bool createMultiMaterialMesh;

	[SerializeField]
	private bool combineInactiveChildren;

	[SerializeField]
	private bool deactivateCombinedChildren;

	[SerializeField]
	private bool deactivateCombinedChildrenMeshRenderers;

	[SerializeField]
	private bool generateUVMap;

	[SerializeField]
	private bool destroyCombinedChildren;

	[SerializeField]
	private string folderPath;

	[SerializeField]
	[Tooltip("MeshFilters with Meshes which we don't want to combine into one Mesh.")]
	private MeshFilter[] meshFiltersToSkip;

	public bool CreateMultiMaterialMesh
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool CombineInactiveChildren
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool DeactivateCombinedChildren
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool DeactivateCombinedChildrenMeshRenderers
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool GenerateUVMap
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool DestroyCombinedChildren
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public string FolderPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void CheckDeactivateCombinedChildren()
	{
	}

	private void CheckDestroyCombinedChildren()
	{
	}

	public void CombineMeshes(bool showCreatedMeshInfo)
	{
	}

	private MeshFilter[] GetMeshFiltersToCombine()
	{
		return null;
	}

	private void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
	{
	}

	private void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
	{
	}

	private void DeactivateCombinedGameObjects(MeshFilter[] meshFilters)
	{
	}

	private void GenerateUV(Mesh combinedMesh)
	{
	}

	public MeshCombiner()
		: base()
	{
	}
}
