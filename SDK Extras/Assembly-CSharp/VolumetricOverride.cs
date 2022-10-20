using UnityEngine;

[RequireComponent(typeof(Camera))]
public class VolumetricOverride : MonoBehaviour
{
	public VolumetricRendering rendering;

	private Camera oldCamRef;

	private void OnEnable()
	{
	}

	private void Reenabling()
	{
	}

	private void OnDisable()
	{
	}

	public VolumetricOverride()
		: base()
	{
	}
}
