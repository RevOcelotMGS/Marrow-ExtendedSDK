using UnityEngine;

public class IgnoreAreaColliders : MonoBehaviour
{
	[Header("Uses a list of colliders to ignore with other local colliders")]
	public Vector3 ColliderBounds;

	private Collider[] SceneColliders;

	[SerializeField]
	private Collider[] CollidersToIgnore;

	private void Awake()
	{
	}

	private void IntializeLoop()
	{
	}

	private void CollectColliders()
	{
	}

	private void ignoreColliders()
	{
	}

	private void DisableCol()
	{
	}

	private void EnableCol()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public IgnoreAreaColliders()
		: base()
	{
	}
}
