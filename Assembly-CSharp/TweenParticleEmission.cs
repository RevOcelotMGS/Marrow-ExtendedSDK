using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class TweenParticleEmission : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem partSys;

	private ParticleSystem.EmissionModule emissionModule;

	private float OrginalEmission;

	private void Reset()
	{
	}

	private void Awake()
	{
	}

	public void TweenOn(float time)
	{
	}

	public void TweenOff(float time)
	{
	}

	private void SetEmission(float currentEmissions, float ratio)
	{
	}

	private void DisableSystem()
	{
	}

	private void EnableSystem()
	{
	}

	public TweenParticleEmission()
		: base()
	{
	}
}
