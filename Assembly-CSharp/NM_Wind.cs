using UnityEngine;

[ExecuteInEditMode]
public class NM_Wind : MonoBehaviour
{
	[Tooltip("Wind Speed in Kilometers per hour")]
	[Header("General Parameters")]
	public float WindSpeed;

	[Tooltip("Wind Turbulence in percentage of wind Speed")]
	[Range(0f, 2f)]
	public float Turbulence;

	[Tooltip("Texture used for wind turbulence")]
	[Header("Noise Parameters")]
	public Texture2D NoiseTexture;

	[Tooltip("Size of one world tiling patch of the Noise Texture, for bending trees")]
	public float FlexNoiseWorldSize;

	[Tooltip("Size of one world tiling patch of the Noise Texture, for leaf shivering")]
	public float ShiverNoiseWorldSize;

	[Header("Gust Parameters")]
	[Tooltip("Texture used for wind gusts")]
	public Texture2D GustMaskTexture;

	[Tooltip("Size of one world tiling patch of the Gust Texture, for leaf shivering")]
	public float GustWorldSize;

	[Tooltip("Wind Gust Speed in Kilometers per hour")]
	public float GustSpeed;

	[Tooltip("Wind Gust Influence on trees")]
	public float GustScale;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnValidate()
	{
	}

	private void ApplySettings()
	{
	}

	private Vector4 GetDirectionAndSpeed()
	{
		return default(Vector4);
	}

	public NM_Wind()
		: base()
	{
	}
}
