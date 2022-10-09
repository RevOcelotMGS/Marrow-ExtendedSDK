using UnityEngine;

public class Control_GlobalAudio : MonoBehaviour
{
	private static Control_GlobalAudio _instance;

	private Control_Player ctrl_Player;

	private float safeguardaudio;

	public static Control_GlobalAudio instance
	{
		get
		{
			return null;
		}
	}

	[HideInInspector]
	public float audio_GlobalVolume
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public Control_GlobalAudio()
		: base()
	{
	}
}
