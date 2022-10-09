using UnityEngine;
using UnityEngine.AI;

[ExecuteInEditMode]
public class NavMeshHeightGen : MonoBehaviour
{
	private NavMeshTriangulation navMeshTriangulated;

	[SerializeField]
	private Material defMaterial;

	[SerializeField]
	private GameObject meshRenderObj;

	[SerializeField]
	private Mesh triangulatedNavMesh;

	[SerializeField]
	private GameObject meshHeightRenderObj;

	[SerializeField]
	private Mesh navHeightMesh;

	[ContextMenu("Triangulate Nav Mesh")]
	public void TriangulateNavMesh()
	{
	}

	public void CreateOGRenderMesh(Mesh generatedMesh)
	{
	}

	[ContextMenu("Create Height Mesh")]
	public void CreateHeightFromNavMesh()
	{
	}

	public void CreateHeightMesh(Mesh generatedMesh)
	{
	}

	public void CreateHeightRenderMesh(Mesh generatedMesh)
	{
	}

	public void OnDrawGizmos()
	{
	}

	public NavMeshHeightGen()
		: base()
	{
	}
}
