using System.Collections.Generic;
using SLZ.Props;
using UnityEngine;

public class NavDestTrigger : MonoBehaviour
{
	[SerializeField]
	private bool isObstructed;

	[SerializeField]
	private int destCount;

	[SerializeField]
	private int costModMult;

	[SerializeField]
	private ObjectDestructable defaultDestObj;

	[Header("LinkTrigger")]
	[SerializeField]
	private bool isLink;

	[SerializeField]
	private LinkData[] linkDatas;

	[Header("NavMeshAreaTrigger")]
	[SerializeField]
	private Arena_GameController gameController;

	[SerializeField]
	private string areaName;

	private HashSet<ObjectDestructable> destHash;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestruction(ObjectDestructable dest)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void ToggleAreaOrLink()
	{
	}

	public NavDestTrigger()
		: base()
	{
	}
}
