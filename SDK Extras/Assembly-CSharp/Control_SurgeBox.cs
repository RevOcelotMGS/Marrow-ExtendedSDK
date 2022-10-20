using SLZ.Interaction;
using UnityEngine;

public class Control_SurgeBox : SurgeBox
{
	[Header("GENERAL")]
	public Vector3 axis_Link;

	public Vector3 axis_LinkSecondary;

	private Rigidbody rb_lever;

	private Quaternion rot_initialize;

	private Quaternion offset_JointSpace;

	[Header("Joint References")]
	[Space(10f)]
	[SerializeField]
	private ConfigurableJoint m_lever;

	[SerializeField]
	private ConfigurableJoint m_closeBttn;

	[SerializeField]
	private ConfigurableJoint m_openBttn;

	[SerializeField]
	private Rigidbody rb_parent;

	[SerializeField]
	private Rigidbody rb_closeBttn;

	[SerializeField]
	private Rigidbody rb_openBttn;

	public Transform override_Anchor;

	[Space(3f)]
	public bool UsingThresholds;

	public int SpringLoc;

	public float[] SpringAngles;

	private Vector3 rot_target;

	public float SpringStrength;

	public float SpringDamper;

	public float LimitMax;

	public float LimitMin;

	private float m_start_OpenBttnPos;

	private float m_start_CloseBttnPos;

	[Header("Button Movement")]
	[Space(5f)]
	public float parentScale;

	private bool flippedDirOpenBttn;

	private bool flippedDirCloseBttn;

	private Vector3 axis_Anchor;

	private Vector3 axis_slide;

	private float limit_LinearOpen;

	private float limit_LinearClosed;

	private float bounce;

	private float contactDistance;

	public float springPower;

	public float damperPower;

	private float slideOpenThreshold;

	[Space(5f)]
	public float tarPos_pressedOpen;

	public float tarPos_pressedClosed;

	public float targPos_restOpen;

	public float tarPos_restClosed;

	[Space(10f)]
	[Header("Card References")]
	public GameObject ChargedCard;

	public GameObject DischargedCard;

	public GameObject OpenCard;

	public GameObject ClosedCard;

	[SerializeField]
	[Space(10f)]
	private int m_leverTries;

	private int m_currLeverTry;

	private FuseInteractionVolume m_fuseVol;

	[SerializeField]
	private bool m_fuseIn;

	private bool m_hasCurrent;

	private bool m_leverUp;

	private bool m_isOpening;

	[SerializeField]
	[Space(10f)]
	[Tooltip("Offset that is added to the higherAngularLimit of the configurablejoint")]
	private float m_highLeverLimit;

	private void Start()
	{
	}

	private void M_SetLeverJoints()
	{
	}

	private void M_SetLimits()
	{
	}

	private void M_SetLink()
	{
	}

	private void M_RotTarget()
	{
	}

	private void M_SetAngles()
	{
	}

	private void M_SetButtonJoints()
	{
	}

	private void M_SetAnchor()
	{
	}

	public void M_Limits()
	{
	}

	public void M_SetDrive()
	{
	}

	public void M_SetTargetPosition()
	{
	}

	private void FixedUpdate()
	{
	}

	private void M_CheckButtonPush()
	{
	}

	public void PutFuseIn()
	{
	}

	public void RemovedFuse()
	{
	}

	private void M_FuseBlown()
	{
	}

	private void M_LeverThresh()
	{
	}

	private void M_PushToOpen()
	{
	}

	private void M_PushToClose()
	{
	}

	private void M_SaveData(bool push)
	{
	}

	private void M_DefaultData()
	{
	}

	public Control_SurgeBox()
		: base()
	{
	}
}
