using UnityEngine;

public class DustParticles : MonoBehaviour
{
	public ParticleSystem ParticleSystem;

	public HoverEngine Engine;

	public float MaxEmission;

	public float DustHeightFudge;

	private void Update()
	{
	}

	public DustParticles()
		: base()
	{
	}
}
