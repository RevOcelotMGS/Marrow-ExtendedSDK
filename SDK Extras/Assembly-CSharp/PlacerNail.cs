using SLZ.Marrow.Warehouse;
using SLZ.SFX;
using UnityEngine;

public class PlacerNail : MonoBehaviour
{
	public AudioClip breakSFX;

	public Transform nailTransform;

	public float breakforce;

	public void OnPlaced(SpawnableCratePlacer placer, GameObject go)
	{
	}

	private void SetJoint(ConfigurableJoint joint, Rigidbody rb)
	{
	}

	private void SetImpactSFX(ImpactSFX impactSFX)
	{
	}

	public PlacerNail()
		: base()
	{
	}
}
