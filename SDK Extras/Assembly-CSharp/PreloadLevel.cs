using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class PreloadLevel : MonoBehaviour
{
	[SerializeField]
	private ShaderVariantCollection variantCollection;

	public List<Vector3> positions;

	public static Action onPreloadStartDelegate;

	public static Action onPreloadCompleteDelegate;

	private Camera[] cam;

	private List<Material> mats;

	private MeshRenderer MR;

	private MeshFilter MF;

	private Mesh mesh;

	private Vector3[] vertices;

	private CommandBuffer renderBuffer;

	private HashSet<Material> matHash;

	private void Start()
	{
	}

	private void InitializeWarmupCameras()
	{
	}

	private void BlackOutVRCamera()
	{
	}

	private void makeBlackoutCommandBuffer(Camera camera)
	{
	}

	private void MakeWarmupCameras()
	{
	}

	private void MaterialWarmup()
	{
	}

	private void GatherMaterials()
	{
	}

	private void InitializeMesh()
	{
	}

	private IEnumerator LocationWarmer()
	{
		return null;
	}

	public PreloadLevel()
		: base()
	{
	}
}
