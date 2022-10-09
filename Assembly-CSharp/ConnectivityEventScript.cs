using RayFire;
using UnityEngine;

public class ConnectivityEventScript : MonoBehaviour
{
	public bool globalSubscription;

	public bool localSubscription;

	public RayfireConnectivity localConnectivityComponent;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LocalMethodConnectivity(RayfireConnectivity connectivity)
	{
	}

	private void GlobalMethodConnectivity(RayfireConnectivity connectivity)
	{
	}

	public ConnectivityEventScript()
		: base()
	{
	}
}
