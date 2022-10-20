using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FPS_CustomLight : MonoBehaviour
{
	private static int MaxLightsCount;

	private Texture2D PointLightAttenuation;

	private List<Light> sceneLights;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private List<Light> GetAllLights()
	{
		return null;
	}

	private int FillDirectionalLights(List<Light> lights, List<Vector4> lightPositions, List<Vector4> lightColors)
	{
		return default(int);
	}

	private int FillPointLights(List<Light> lights, List<Vector4> lightPositions, List<Vector4> lightColors)
	{
		return default(int);
	}

	private Vector4[] ListToArrayWithMaxCount(List<Vector4> list, int count)
	{
		return null;
	}

	private List<Light> SortPointLightsByDistance(List<Light> lights)
	{
		return null;
	}

	public Color SampleLightProbesUp(Vector3 pos, float grayScaleFactor)
	{
		return default(Color);
	}

	private Texture2D GeneratePointAttenuationTexture()
	{
		return null;
	}

	public FPS_CustomLight()
		: base()
	{
	}
}
