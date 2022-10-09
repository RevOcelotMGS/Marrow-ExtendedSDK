using UnityEngine;

public class AnalogClock : MonoBehaviour
{
	private const float hoursToDegrees = 30f;

	private const float minutesToDegrees = 6f;

	private const float secondsToDegrees = 6f;

	public Transform hours;

	public Transform minutes;

	public Transform seconds;

	private bool isClocking;

	public AnimationCurve curve_Pendulum;

	public Transform[] pendulum;

	private Vector3 pendulumRot;

	private float cur_penTime;

	public float mod_pendulum;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public AnalogClock()
		: base()
	{
	}
}
