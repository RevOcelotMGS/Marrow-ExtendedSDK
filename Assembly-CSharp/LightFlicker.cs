using UnityEngine;

public class LightFlicker : MonoBehaviour
{
	public float MinLightIntensity;

	public float MaxLightIntensity;

	public float AccelerateTime;

	private float _targetIntensity;

	private float _lastIntensity;

	private float _timePassed;

	private Light _lt;

	private const double Tolerance = 0.0001;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public LightFlicker()
		: base()
	{
	}
}
