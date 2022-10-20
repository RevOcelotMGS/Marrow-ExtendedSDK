using SLZ.Rig;
using UnityEngine;

public class TriggerLasers : MonoBehaviour
{
	[SerializeField]
	private LayerMask LayerFilter;

	[SerializeField]
	private UnityEventTrigger OnTriggerEnterEvent;

	[SerializeField]
	private UnityEventTrigger OnTriggerExitEvent;

	public GameObject obj_SpecificTrigger;

	public float bufferTime;

	public bool OneTimeUse;

	public bool onlyTriggerOnPlayer;

	public RigManager rigManager;

	private bool used;

	private int _triggerLayer;

	private Collider cachedCol;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void BufferedEnter()
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public TriggerLasers()
		: base()
	{
	}
}
