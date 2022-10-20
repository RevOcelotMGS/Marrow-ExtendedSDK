using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SLZAudioRouting : MonoBehaviour
{
	public int target;

	private bool ready;

	private void Start()
	{
	}

	public SLZAudioRouting()
		: base()
	{
	}
}
