using System.Runtime.InteropServices;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_MeshBakerGrouper : MonoBehaviour, MB_IMeshBakerSettingsHolder
{
	public enum ClusterType
	{
		none = 0,
		grid = 1,
		pie = 2,
		agglomerative = 3
	}

	public static readonly Color WHITE_TRANSP;

	public MB3_MeshBakerGrouperCore grouper;

	public ClusterType clusterType;

	public Transform parentSceneObject;

	public GrouperData data;

	[HideInInspector]
	public Bounds sourceObjectBounds;

	public string prefabOptions_outputFolder;

	public bool prefabOptions_autoGeneratePrefabs;

	public bool prefabOptions_mergeOutputIntoSinglePrefab;

	public MB3_MeshCombinerSettings meshBakerSettingsAsset;

	public MB3_MeshCombinerSettingsData meshBakerSettings;

	public MB_IMeshBakerSettings GetMeshBakerSettings()
	{
		return null;
	}

	public void GetMeshBakerSettingsAsSerializedProperty([Out] string propertyName, [Out] Object targetObj)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public MB3_MeshBakerGrouperCore CreateGrouper(ClusterType t, GrouperData data)
	{
		return null;
	}

	public void DeleteAllChildMeshBakers()
	{
	}

	public MB3_MeshBakerGrouper()
		: base()
	{
	}
}
