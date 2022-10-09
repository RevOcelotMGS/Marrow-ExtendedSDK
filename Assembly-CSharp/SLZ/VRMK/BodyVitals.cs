using System.Runtime.CompilerServices;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.VRMK
{
	public class BodyVitals : MonoBehaviour
	{
		public enum MeasurementState
		{
			CUSTOM = 0,
			XSMALL = 1,
			SMALL = 2,
			MEDIUM = 3,
			LARGE = 4,
			XLARGE = 5,
			XXLARGE = 6,
			XXXLARGE = 7
		}

		public delegate void RescaleUI();

		[Range(1f, 2.1f)]
		public float realWorldHeight;

		public MeasurementState measurementPresets;

		public float chestCircumference;

		public float underbustCircumference;

		public float waistCircumference;

		public float hipsCircumference;

		public float wingspan;

		public float inseam;

		[Range(0f, 0.8f)]
		public float sittingOffset;

		public float floorOffset;

		[HideInInspector]
		public int loco_CurveMode;

		[HideInInspector]
		public int loco_Direction;

		public float loco_DegreesPerSnap;

		[HideInInspector]
		public int loco_SnapDegreesPerFrame;

		[HideInInspector]
		public float mod_globalHaptic;

		[HideInInspector]
		public float cur_Strength;

		[HideInInspector]
		public float crouch_Speed;

		[HideInInspector]
		public float reverse_Speed;

		[HideInInspector]
		public float walk_Speed;

		[HideInInspector]
		public float jog_Speed;

		[HideInInspector]
		public float run_Speed;

		[HideInInspector]
		public float sprint_Speed;

		[HideInInspector]
		public float mod_Jump;

		[HideInInspector]
		public float blood_BPM;

		[HideInInspector]
		public float blood_Oxygen;

		[HideInInspector]
		public float use_Arm_L;

		[HideInInspector]
		public float use_Arm_R;

		[HideInInspector]
		public float use_Legs;

		[HideInInspector]
		public float cur_Speed;

		[HideInInspector]
		public float accumulated_Legs;

		[HideInInspector]
		public float accumulated_Arms;

		[HideInInspector]
		public float force_Jump;

		[HideInInspector]
		public bool locoEnabled;

		[HideInInspector]
		public bool turnEnabled;

		[HideInInspector]
		public bool crouchEnabled;

		[HideInInspector]
		public bool jumpEnabled;

		[HideInInspector]
		public bool quickmenuEnabled;

		[HideInInspector]
		public bool slowTimeEnabled;

		[HideInInspector]
		public bool isRightHanded;

		[HideInInspector]
		public bool beltFlipped;

		[HideInInspector]
		public float uiScaling;

		public bool hasBodyLog;

		public bool bodyLogEnabled;

		public bool bodyLogFlipped;

		public Vector3 checkpointPosition;

		public Vector3 checkpointFwd;

		public bool fwdOnPort;

		public RigManager mngr_Rig;

		[HideInInspector]
		[Range(0f, 1f)]
		public float counterScaleCam;

		public ControllerRig ctrl_Rig;

		private void Start()
		{
		}

		public void PROPEGATE()
		{
		}

		public void PROPEGATE_SOFT()
		{
		}

		public void CalibratePlayerBodyScale()
		{
		}

		public void CalibratePlayerBodyScale(RigManager manager)
		{
		}

		private void ApplyControlInputSettings(ControllerRig ctrl_Rig)
		{
		}

		private void ApplyUILayoutSettings()
		{
		}

		public BodyVitals()
			: base()
		{
		}

		public event RescaleUI rescaleEvent;
	}
}
