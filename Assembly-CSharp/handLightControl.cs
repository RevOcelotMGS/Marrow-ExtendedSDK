using SLZ.Interaction;
using UnityEngine;

public class handLightControl : MonoBehaviour
{
	public Light handLight;

	public Grip grip;

	public Rigidbody rB;

	public Color[] color;

	public float[] intensity;

	private ConfigurableJoint _joint;

	private int _currentColor;

	private int _currentIntensity;

	private void Awake()
	{
	}

	private void UpdateColor(int setting)
	{
	}

	private void UpdateIntensity(int setting)
	{
	}

	private void UpdateLight(Hand hand)
	{
	}

	private void RemoveJoint(Hand hand)
	{
	}

	private void AddJoint(Hand hand)
	{
	}

	public handLightControl()
		: base()
	{
	}
}
