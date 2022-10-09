using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TrainLines : MonoBehaviour
{
	[SerializeField]
	private string targetTag;

	[SerializeField]
	private LineRenderer line;

	private Transform startPoint;

	private Transform connection1;

	private Transform connection2;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public TrainLines()
		: base()
	{
	}
}
