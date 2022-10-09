using UnityEngine;

public class SaveIndication : MonoBehaviour
{
	public SimpleSFX simpleSFX;

	public GameObject flashCone;

	public float flashActiveTime;

	public ParticleSystem particles;

	[Tooltip("The material to assign on save start")]
	public Material material;

	[Tooltip("Assumes there is only one material on each renderer and that it will be swapped to the new material")]
	public MeshRenderer[] renderers;

	[ContextMenu("IndicateSave")]
	public void IndicateSave()
	{
	}

	private void TurnOffFlash()
	{
	}

	public SaveIndication()
		: base()
	{
	}
}
