using SLZ.Interaction;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Events;

public class GammonDissolver : MonoBehaviour
{
	public Grip grip;

	public AssetPoolee poolee;

	public UnityEvent onDespawned;

	public AudioClip despawnClip;

	private void Awake()
	{
	}

	public void OnHandAttached(Hand hand)
	{
	}

	public GammonDissolver()
		: base()
	{
	}
}
