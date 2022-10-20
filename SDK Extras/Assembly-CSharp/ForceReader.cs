using UnityEngine;

public class ForceReader : MonoBehaviour
{
	[SerializeField]
	private string tagToDetect;

	private void OnCollisionEnter(Collision col)
	{
	}

	public ForceReader()
		: base()
	{
	}
}
