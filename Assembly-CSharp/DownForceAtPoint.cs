using UnityEngine;

public class DownForceAtPoint : MonoBehaviour
{
	[SerializeField]
	private Rigidbody parentBody;

	public float downForce;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public DownForceAtPoint()
		: base()
	{
	}
}
