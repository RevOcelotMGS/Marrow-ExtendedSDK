using UnityEngine;

[ExecuteInEditMode]
public class FPS_Decal : MonoBehaviour
{
	public bool ScreenSpaceDecals;

	public float randomScalePercent;

	private MaterialPropertyBlock props;

	private MeshRenderer rend;

	private Vector3 startScale;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public FPS_Decal()
		: base()
	{
	}
}
