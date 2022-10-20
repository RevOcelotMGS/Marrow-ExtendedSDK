using SLZ.Interaction;
using SLZ.Props.Weapons;
using UnityEngine;

public class DominantEjectSwitcher : MonoBehaviour
{
	public Grip grip;

	public Gun gun;

	public Transform rightEject;

	public Transform leftEject;

	private void Start()
	{
	}

	private void OnGrip(Hand hand)
	{
	}

	public DominantEjectSwitcher()
		: base()
	{
	}
}
