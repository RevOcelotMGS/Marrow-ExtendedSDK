using SLZ.Interaction;
using UnityEngine;

public class PropKnife : CylinderGrip
{
	public ConfigurableJoint jnt_blade;

	public AudioSource src_Audio;

	public AudioClip clip_knifeUp;

	public AudioClip clip_knifeDown;

	public bool knifeUp;

	private bool clicked;

	private void FlickKnife()
	{
	}

	public PropKnife()
		: base()
	{
	}
}
