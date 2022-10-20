using SLZ.Interaction;
using UnityEngine;

public class GrabDisable : MonoBehaviour
{
	public GameObject disableObject;

	public Grip grip;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnAttached(Hand hand)
	{
	}

	public GrabDisable()
		: base()
	{
	}
}
