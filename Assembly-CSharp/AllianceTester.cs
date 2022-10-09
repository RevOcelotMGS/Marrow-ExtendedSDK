using SLZ.AI;
using UnityEngine;

public class AllianceTester : MonoBehaviour
{
	public TriggerRefProxy[] proxies;

	public TriggerRefProxy proxyA;

	public TriggerRefProxy proxyB;

	private bool result;

	public void Start()
	{
	}

	[ContextMenu("FindAllProxies")]
	public void FindAllProxies()
	{
	}

	[ContextMenu("TestAlliance")]
	public void TestAlliance()
	{
	}

	public AllianceTester()
		: base()
	{
	}
}
