using SLZ.Props.Weapons;
using UnityEngine;

public class GunPlatformDiscriminator : MonoBehaviour
{
	[SerializeField]
	[Header("References")]
	private Gun gun;

	[SerializeField]
	[Header("PC")]
	private MeshRenderer chargingHelperPC;

	[SerializeField]
	private MeshRenderer magazineHelperPC;

	[Header("Quest")]
	[SerializeField]
	private MeshRenderer chargingHelperQ;

	[SerializeField]
	private MeshRenderer magazineHelperQ;

	private void Awake()
	{
	}

	private void SetReferences(bool isQuest)
	{
	}

	public GunPlatformDiscriminator()
		: base()
	{
	}
}
