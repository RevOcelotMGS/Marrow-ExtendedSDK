using UnityEngine;

public class SkinnedBoneRebind : MonoBehaviour
{
	public Transform[] bones;

	public bool[] rebindBone;

	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Header("Bind Pose Tool")]
	public Mesh meshToRead;

	public Mesh meshToWrite;

	private void Awake()
	{
	}

	private void RebindTool()
	{
	}

	public SkinnedBoneRebind()
		: base()
	{
	}
}
