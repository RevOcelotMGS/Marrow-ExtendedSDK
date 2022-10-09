using System.Collections.Generic;
using System.Runtime.InteropServices;
using DigitalOpus.MB.Core;
using UnityEngine;

public abstract class MB3_MeshBakerCommon : MB3_MeshBakerRoot
{
	public class Cluster
	{
		public List<int> vertIndexes;

		public Vector3 averagePostion;

		public Vector3[] averageNormals;

		public void CalcAveragePos(Vector3[] vs)
		{
		}

		public void CalcAverageNorm(Vector3[] vNs, float AngleThreshold)
		{
		}

		public Cluster()
			: base()
		{
		}
	}

	public List<GameObject> objsToMesh;

	public bool useObjsToMeshFromTexBaker;

	public bool clearBuffersAfterBake;

	public string bakeAssetsInPlaceFolderPath;

	[HideInInspector]
	public GameObject resultPrefab;

	[HideInInspector]
	public bool resultPrefabLeaveInstanceInSceneAfterBake;

	[HideInInspector]
	public Transform parentSceneObject;

	public abstract MB3_MeshCombiner meshCombiner { get; }

	public override MB2_TextureBakeResults textureBakeResults
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	public void EnableDisableSourceObjectRenderers(bool show)
	{
	}

	public virtual void ClearMesh()
	{
	}

	public virtual void ClearMesh(MB2_EditorMethodsInterface editorMethods)
	{
	}

	public virtual void DestroyMesh()
	{
	}

	public virtual void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	public virtual int GetNumObjectsInCombined()
	{
		return default(int);
	}

	public virtual int GetNumVerticesFor(GameObject go)
	{
		return default(int);
	}

	public MB3_TextureBaker GetTextureBaker()
	{
		return null;
	}

	public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

	public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true);

	public virtual void Apply(MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod = default(MB3_MeshCombiner.GenerateUV2Delegate))
	{
	}

	public virtual void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapesFlag = false, MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod = default(MB3_MeshCombiner.GenerateUV2Delegate))
	{
	}

	public virtual bool CombinedMeshContains(GameObject go)
	{
		return default(bool);
	}

	public virtual void UpdateGameObjects(GameObject[] gos)
	{
	}

	public virtual void UpdateGameObjects(GameObject[] gos, bool updateBounds)
	{
	}

	public virtual void UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV1, bool updateUV2, bool updateColors, bool updateSkinningInfo)
	{
	}

	public virtual bool UpdateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateUV5, bool updateUV6, bool updateUV7, bool updateUV8, bool updateColors, bool updateSkinningInfo)
	{
		return default(bool);
	}

	public virtual void UpdateSkinnedMeshApproximateBounds()
	{
	}

	public virtual void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	public virtual void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	protected virtual bool _ValidateForUpdateSkinnedMeshBounds()
	{
		return default(bool);
	}

	[ContextMenu("Bake And Weld Verts")]
	public void WeldAndBlendVerts()
	{
	}

	public MB3_MeshBakerCommon()
		: base()
	{
	}
}
