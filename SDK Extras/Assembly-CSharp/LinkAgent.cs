using Assets.Marrow_ExtendedSDK.StubClasses;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class LinkAgent : Agent
{
	public Rigidbody m_AgentRb;

	private RaycastHit linkCast;

	public float maxLinkDistance;

	private float lookingAtLink;

	private int defaultMask;

	public HingeJoint[] connectPoints;

	private GameObject farthestBack;

	public float LookForLinks()
	{
		return default(float);
	}

	public void AttemptLink()
	{
	}

	public void MoveAgent(ActionSegment<int> act)
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public LinkAgent()
		: base()
	{
	}
}
