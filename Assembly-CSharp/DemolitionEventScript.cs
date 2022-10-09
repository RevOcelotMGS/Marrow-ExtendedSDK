using RayFire;
using UnityEngine;

public class DemolitionEventScript : MonoBehaviour
{
	public bool globalSubscription;

	public bool localSubscription;

	public RayfireRigid localRigidComponent;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LocalMethod(RayfireRigid rigid)
	{
	}

	private void GlobalMethod(RayfireRigid rigid)
	{
	}

	public DemolitionEventScript()
		: base()
	{
	}
}
