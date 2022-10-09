using SLZ.Interaction;
using UnityEngine;

public class PropFlashlight : CylinderGrip
{
	public GameObject LightStuff;

	public AudioSource src_Audio;

	public AudioClip clip_downClick;

	public AudioClip clip_upClick;

	public bool lightOn;

	public Renderer[] renderers;

	[ColorUsage(true, true)]
	public Color onColor;

	[ColorUsage(true, true)]
	public Color offColor;

	private bool clicked;

	private void SwitchLight()
	{
	}

	public PropFlashlight()
		: base()
	{
	}
}
