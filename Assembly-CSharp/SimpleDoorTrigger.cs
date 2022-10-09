using UnityEngine;

public class SimpleDoorTrigger : MonoBehaviour
{
	public Transform Door;

	public float OpenAngleAmount;

	public float SmoothRotation;

	public string interactText;

	public GUIStyle InteractTextStyle;

	private bool init;

	private bool hasEntered;

	private bool doorOpen;

	private Vector3 startAngle;

	private Vector3 openAngle;

	private Rect interactTextRect;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnGUI()
	{
	}

	private void HandleDoorRotation()
	{
	}

	private void HandleUserInput()
	{
	}

	public SimpleDoorTrigger()
		: base()
	{
	}
}
