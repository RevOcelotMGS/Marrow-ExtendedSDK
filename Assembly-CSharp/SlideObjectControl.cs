using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(ConfigurableJoint))]
public class SlideObjectControl : MonoBehaviour
{
	private Vector3 SlideDirection;

	private ConfigurableJoint m_configJoint;

	private Rigidbody m_rb;

	[Header("Drawer Movement")]
	private bool flippedDir;

	private float openGap;

	private float closeGap;

	public float parentScale;

	public bool FreeDrawer;

	private bool DrawerOpen;

	private Vector3 axis_Anchor;

	private Vector3 axis_slide;

	private float limit_Linear;

	private float bounce;

	private float contactDistance;

	public float springPower;

	public float damperPower;

	public float maxForce;

	private float slideOpenThreshold;

	[Space(5f)]
	public float targetPosition_closed;

	public float targetPosition_open;

	private Vector3 desiredPosition;

	[Header("Lock")]
	[Space(10f)]
	public bool Locked;

	public AudioClip[] clip_Locked;

	public AudioClip[] clip_Lock;

	public AudioClip[] clip_Unlock;

	[Space(10f)]
	private bool canSlam;

	public AudioClip clip_Slam;

	private void Start()
	{
	}

	public void SetUpJoint()
	{
	}

	private void ANCHOR()
	{
	}

	public void LOCKLIMITS()
	{
	}

	public void SETDRIVE()
	{
	}

	public void OPENCLOSE()
	{
	}

	private void FixedUpdate()
	{
	}

	public void LockUnlock(bool locked, bool hasKey)
	{
	}

	private void PlaySound(AudioClip clip, float force = 1f)
	{
	}

	public SlideObjectControl()
		: base()
	{
	}
}
