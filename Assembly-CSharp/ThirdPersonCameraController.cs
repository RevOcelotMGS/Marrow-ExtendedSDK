using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
	public Transform headTransform;

	public Transform bodyTransform;

	public float camDistance;

	public float lookDistance;

	public float rightDistance;

	public float upDistance;

	public float rotateLookSpeed;

	public float moveSpeed;

	private void Update()
	{
	}

	public ThirdPersonCameraController()
		: base()
	{
	}
}
