using SLZ.Rig;
using UnityEngine;

public class HeadTitlesTrigger : MonoBehaviour
{
	public AudioClip clipToPlay;

	public string string_Title;

	public string string_SubTitle;

	public Sprite spriteToDisplay;

	public float bufferTime;

	[Header("LEVEL TRIGGER")]
	public bool isLevel;

	public Sprite[] levelSprites;

	[Header("AVATAR LEVEL TRIGGER")]
	public bool isAvatarLevel;

	public Sprite spriteA;

	public Sprite spriteB;

	public Sprite spriteC;

	public Sprite spriteD;

	private float timeToSend;

	private string currentTag;

	private RigManager manager;

	public void SENDTITLES()
	{
	}

	public HeadTitlesTrigger()
		: base()
	{
	}
}
