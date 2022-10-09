using SLZ.Marrow.Data;
using SLZ.Rig;
using UnityEngine;

public class LinkDataManager : MonoBehaviour
{
	public BaseGameController baseGameController;

	public RigManager rigManager;

	public LaunchHelper launchHelper;

	public AudioClip launchClip;

	public AudioClip enableTargClip;

	public AudioClip disableTargClip;

	public GameObject climbLinkPrefab;

	public GameObject jumpLinkPrefab;

	public GameObject launchLinkPrefab;

	public GameObject launchLinkArtPrefab;

	public GameObject slideLinkPrefab;

	public GameObject climbBarLinkPrefab;

	public GameObject climbLedgeLinkPrefab;

	public GameObject zipLinePrefab;

	public GameObject partialZipLinkPrefab;

	public Spawnable zipStickSpawnable;

	public GameObject zipJointMoverPrefab;

	public GameObject zipMechPrefab;

	public GameObject zipMechGripPrefab;

	public GameObject zipBarPrefab;

	public void Awake()
	{
	}

	public LinkDataManager()
		: base()
	{
	}
}
