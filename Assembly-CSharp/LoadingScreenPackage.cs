using System.Collections.Generic;
using UnityEngine;

public class LoadingScreenPackage : MonoBehaviour
{
	[HideInInspector]
	public float alpha;

	[HideInInspector]
	public List<ulong> overlayList;

	[Tooltip("Scale load-o-rama with camera scale?")]
	public bool ScaleWithCamera;

	[Tooltip("Rotate load-o-rama with camera rot?")]
	public bool RotWithCamera;

	public Texture invisibleTexture;

	public Texture groundTexture;

	private string renderModelPath;

	public Color renderModelColor;

	private Color _overlayRenderModelColor_U;

	[Header("Scaler")]
	public Texture scalingTexture;

	[HideInInspector]
	public ulong scalingOverlayHandle;

	public float scaleSpeed;

	public float scaleMax;

	public float scaleMin;

	public Color overlayRenderModelColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public void PackageCreate()
	{
	}

	public void HideOverlays()
	{
	}

	public void DestroyOverlays(ulong[] overlayHandles)
	{
	}

	private void DestroyOverlay(ulong overlayHandle)
	{
	}

	public void StartAlpha()
	{
	}

	public void AlphaOverlays(float incAlpha)
	{
	}

	private ulong GetOverlayHandle(string overlayName, Transform transforma, float widthInMeters = 1f, bool isMesh = false)
	{
		return default(ulong);
	}

	public LoadingScreenPackage()
		: base()
	{
	}
}
