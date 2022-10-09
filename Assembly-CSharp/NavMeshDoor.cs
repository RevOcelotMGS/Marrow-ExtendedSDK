using UnityEngine;

public class NavMeshDoor : MonoBehaviour
{
	public enum DoorType
	{
		DoorA = 0,
		DoorB = 1,
		DoorC = 2,
		DoorD = 3,
		DoorE = 4
	}

	public DoorType doorType;

	[SerializeField]
	private bool isOpen;

	[SerializeField]
	private Vector3 openPos;

	[SerializeField]
	private Vector3 closePos;

	[SerializeField]
	private AudioClip openClip;

	[SerializeField]
	private AudioClip closeClip;

	public void ToggleDoor()
	{
	}

	private void OpenDoor()
	{
	}

	private void CloseDoor()
	{
	}

	public void ToggleArea(bool open)
	{
	}

	public NavMeshDoor()
		: base()
	{
	}
}
