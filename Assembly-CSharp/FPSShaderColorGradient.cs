using UnityEngine;

public class FPSShaderColorGradient : MonoBehaviour
{
	public enum RFX4_ShaderProperties
	{
		_TintColor = 0,
		_Cutoff = 1,
		_Color = 2,
		_EmissionColor = 3,
		_MaskPow = 4,
		_Cutout = 5,
		_Speed = 6,
		_BumpAmt = 7,
		_MainColor = 8,
		_Distortion = 9,
		_FresnelColor = 10
	}

	public RFX4_ShaderProperties ShaderColorProperty;

	public Gradient Color;

	public float TimeMultiplier;

	public bool IsLoop;

	[HideInInspector]
	public bool canUpdate;

	private int propertyID;

	private float startTime;

	private Color startColor;

	private bool isInitialized;

	private string shaderProperty;

	private MaterialPropertyBlock props;

	private Renderer rend;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public FPSShaderColorGradient()
		: base()
	{
	}
}
