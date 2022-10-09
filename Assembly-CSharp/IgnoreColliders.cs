using UnityEngine;

public class IgnoreColliders : MonoBehaviour
{
	public Collider[] collidersA;

	public Collider[] collidersB;

	public bool ignoreOnAwake;

	private void Awake()
	{
	}

	public void Ignore()
	{
	}

	public void Unignore()
	{
	}

	public IgnoreColliders()
		: base()
	{
	}
}
