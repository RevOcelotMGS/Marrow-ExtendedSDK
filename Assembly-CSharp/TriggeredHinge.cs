using UnityEngine;

public class TriggeredHinge : MonoBehaviour
{
	public ConfigurableJoint joint;

	public AudioClip[] openClips;

	public AudioClip[] closeClips;

	private float _minAngle;

	private float _maxAngle;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Release()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public TriggeredHinge()
		: base()
	{
	}
}
