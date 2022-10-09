using UnityEngine;

public class CrowdAnim : MonoBehaviour
{
	[SerializeField]
	private float _posDiff;

	private float t;

	private float timer;

	[SerializeField]
	[Range(0.01f, 100f)]
	private float animSpeed;

	private void Start()
	{
	}

	public void ToggleExcitement(bool enable)
	{
	}

	private void Update()
	{
	}

	public CrowdAnim()
		: base()
	{
	}
}
