using UnityEngine;

public class TargetHealth : MonoBehaviour
{
	public float baseHealth;

	[HideInInspector]
	public float currentHealth;

	private void Awake()
	{
	}

	public bool TakeDamage(float dmg)
	{
		return default(bool);
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public TargetHealth()
		: base()
	{
	}
}
