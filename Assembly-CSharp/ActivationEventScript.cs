using RayFire;
using UnityEngine;

public class ActivationEventScript : MonoBehaviour
{
	[Header("  Rigid Activation")]
	public bool globalSubscriptionRigid;

	public bool localSubscriptionRigid;

	public RayfireRigid localRigidComponent;

	[Header("  RigidRoot Activation")]
	public bool globalSubscriptionRoot;

	public bool localSubscriptionRoot;

	public RayfireRigidRoot localRigidRootComponentRoot;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LocalMethodRigid(RayfireRigid rigid)
	{
	}

	private void GlobalMethodRigid(RayfireRigid rigid)
	{
	}

	private void LocalMethodRoot(RayfireRigidRoot root)
	{
	}

	private void GlobalMethodRoot(RayfireRigidRoot root)
	{
	}

	public ActivationEventScript()
		: base()
	{
	}
}
