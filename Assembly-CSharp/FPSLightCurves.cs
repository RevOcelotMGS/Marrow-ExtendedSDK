using UnityEngine;

public class FPSLightCurves : MonoBehaviour
{
	public AnimationCurve LightCurve;

	public float GraphTimeMultiplier;

	public float GraphIntensityMultiplier;

	private bool canUpdate;

	private float startTime;

	private Light lightSource;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public FPSLightCurves()
		: base()
	{
	}
}
