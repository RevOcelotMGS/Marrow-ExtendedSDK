using HTC.UnityPlugin.FoveatedRendering;
using UnityEngine;

[RequireComponent(typeof(ViveFoveatedRendering))]
public class ViveFoveatedVisualizer : MonoBehaviour
{
	private ViveFoveatedRendering viveFoveatedRendering;

	private Material visualizeMat;

	private Camera thisCamera;

	private Vector3 normalizedGazeDirection;

	private Vector2 eyeResolution;

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	public ViveFoveatedVisualizer()
		: base()
	{
	}
}
