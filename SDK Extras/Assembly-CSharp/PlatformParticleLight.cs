using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class PlatformParticleLight : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem ps;

	private void Reset()
	{
	}

	public PlatformParticleLight()
		: base()
	{
	}
}
