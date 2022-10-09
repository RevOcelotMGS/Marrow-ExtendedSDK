using UnityEngine;

public class MB3_BoneWeightCopier : MonoBehaviour
{
	public GameObject inputGameObject;

	public GameObject outputPrefab;

	public float radius;

	public SkinnedMeshRenderer seamMesh;

	public string outputFolder;

	public MB3_BoneWeightCopier()
		: base()
	{
	}
}
