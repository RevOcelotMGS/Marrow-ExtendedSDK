using UnityEngine;

public class SimpleMove_Car : MonoBehaviour
{
	public GameObject parent;

	public float moveSpeed;

	public string resetTag;

	[HideInInspector]
	public bool moveCar;

	private void MoveForward()
	{
	}

	public void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public SimpleMove_Car()
		: base()
	{
	}
}
