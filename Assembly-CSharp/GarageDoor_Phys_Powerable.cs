using UnityEngine;

public class GarageDoor_Phys_Powerable : Powerable
{
	[Space(5f)]
	[Header("GARAGE REFS")]
	public bool isBinary;

	public bool isMotorized;

	[Space(5f)]
	[Header("VOLTAGE OFFSET")]
	[Range(0f, 0.2f)]
	public float lowerOffSet;

	[Range(0f, 0.8f)]
	public float higherOffset;

	[Range(-1f, 1f)]
	[Space(5f)]
	public float min_InputVoltage;

	[Range(-1f, 1f)]
	public float max_InputVoltage;

	[Space(5f)]
	public float min_TargetVoltage;

	public float max_TargetVoltage;

	private float cur_InputVoltage;

	[Space(5f)]
	[Header("JOINTS")]
	public ConfigurableJoint m_configJoint;

	public Rigidbody m_rb;

	private bool FreeDoorOpen;

	private float openGap;

	private float closeGap;

	public float parentScale;

	private Vector3 Anchor;

	private Vector3 axis_slide;

	private float limit_Linear;

	private float bounce;

	private float contactDistance;

	public float springPower;

	[Tooltip("How much spring force multiplied to the springPower when not motorized")]
	public float springFreeHandMod;

	public float damperPower;

	[Tooltip("How much dampen force multiplied to the damperPower when not motorized")]
	public float damperMod;

	public float motor_forcePower;

	public float free_forcePower;

	public float locked_forcePower;

	[Tooltip("Modifier for the garage door's movement in Time.deltaTime")]
	public float speedMod;

	[Space(3f)]
	[Range(-12f, 12f)]
	[Tooltip("-1.4 fully open, 1.4 fully closed")]
	public float startTarPos;

	[Space(5f)]
	public float tarPos_closed;

	public float tarPos_open;

	public Vector3 desiredPosition;

	[Space(5f)]
	[Header("SLATS")]
	public GameObject[] Slats;

	[Header("LOCK")]
	public bool Locked;

	[Tooltip("The threshold for the locked mode to break")]
	public float lockBreakThresh;

	[Header("Occlusion Portal")]
	[SerializeField]
	private OcclusionPortal occlusionPortal;

	private float stored_Draw;

	[Header("DEBUG")]
	public bool isDebugging;

	private int prevVal;

	private void Start()
	{
	}

	public void SetUpJoint()
	{
	}

	private void ANCHOR()
	{
	}

	public void LIMITS()
	{
	}

	public void SETDRIVE()
	{
	}

	public void LOCKFORCE()
	{
	}

	public void ToggleVoltage()
	{
	}

	public void FlipVoltage()
	{
	}

	private void OPENCLOSE_DOOR(float attnVoltage)
	{
	}

	private void FREEOPENCLOSE_DOOR()
	{
	}

	private float SetMoveRate(float Voltage)
	{
		return default(float);
	}

	private void Update()
	{
	}

	private void UpdateDoor()
	{
	}

	private int TurnOffSlatRemap(float position)
	{
		return default(int);
	}

	public GarageDoor_Phys_Powerable()
		: base()
	{
	}
}
