using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
	public Transform setCamera;

	public Transform cameraTarget;

	public float followDistance;

	public float followHeight;

	public float followSensitivity;

	public bool useRaycast;

	public Vector2 axisSensitivity;

	public float camFOV;

	public float camRotation;

	public float camHeight;

	public float camYDamp;

	public Vector2 camLookOffset;

	private float MouseRotationDistance;

	private float MouseVerticalDistance;

	private float MouseScrollDistance;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public ControllerCamera()
		: base()
	{
	}
}
