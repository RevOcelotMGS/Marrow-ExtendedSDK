using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class PlatformMaterial : MonoBehaviour
{
	[SerializeField]
	private Renderer TargetRenderer;

	[Space(20f)]
	[SerializeField]
	private Material Android;

	[SerializeField]
	private Material PC;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	public PlatformMaterial()
		: base()
	{
	}
}
