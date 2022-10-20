using System.Collections.Generic;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class Trial_GripEvents : MonoBehaviour
{
	public GameObject[] weaponObjects;

	public List<Grip> gripsList;

	public UnityEvent onGrabbed;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnGrab(Hand hand)
	{
	}

	[ContextMenu("GetAllGrips")]
	public void GetAllGrips()
	{
	}

	public Trial_GripEvents()
		: base()
	{
	}
}
