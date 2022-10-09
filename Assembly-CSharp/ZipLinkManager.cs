using System.Collections.Generic;
using System.Runtime.InteropServices;
using SLZ.AI;
using UnityEngine;

public class ZipLinkManager : MonoBehaviour
{
	public List<AgentLinkControl> agentList;

	public List<LinkData> downLinksList;

	public List<LinkData> upLinksList;

	public List<LinkData> linkList;

	public float delayedTime;

	public TriggerRefProxy playerProxy;

	public ZipLinkSetup zipLinkSetup;

	public GameObject partialLinkSetupPrefab;

	public int zipStickLength;

	private void Awake()
	{
	}

	public void ClaimZipDownLinks(AgentLinkControl agentController, LinkData linkData)
	{
	}

	public void ReleaseZipDownLinks(AgentLinkControl agentController)
	{
	}

	public void ClaimZipUpLinks(TriggerRefProxy proxy = default(TriggerRefProxy), AgentLinkControl agentController = default(AgentLinkControl))
	{
	}

	public void ReleaseZipUpLinks()
	{
	}

	[ContextMenu("Create Zip Up Partial Link")]
	public void CreatePartialZipUpLink()
	{
	}

	[ContextMenu("Create Zip Down Partial Link")]
	public void CreatePartialZipDownLink()
	{
	}

	public LinkData CopyLinkData(LinkData ogLinkData, GameObject linkDataGO)
	{
		return null;
	}

	public ZipLinkManager()
		: base()
	{
	}
}
