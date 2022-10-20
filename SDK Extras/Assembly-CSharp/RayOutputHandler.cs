using Assets.Marrow_ExtendedSDK.StubClasses;
using UnityEngine;

public class RayOutputHandler : MonoBehaviour
{
	public RayPerceptionSensorComponent3D eye_reference;

	[HideInInspector]
	public RayPerceptionOutput eyes_output;

	private void FixedUpdate()
	{
	}

	public RayOutputHandler()
		: base()
	{
	}
}
