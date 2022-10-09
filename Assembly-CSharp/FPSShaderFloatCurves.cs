using UnityEngine;

public class FPSShaderFloatCurves : MonoBehaviour
{
	public string ShaderProperty;

	public int MaterialID;

	public AnimationCurve FloatPropertyCurve;

	public float GraphTimeMultiplier;

	public float GraphScaleMultiplier;

	private bool canUpdate;

	private Material matInstance;

	private int propertyID;

	private float startTime;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public FPSShaderFloatCurves()
		: base()
	{
	}
}
