using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.AI;

[ExecuteInEditMode]
public class LinkData : MonoBehaviour
{
	public enum LinkType
	{
		CLIMB = 0,
		JUMP = 1,
		LAUNCH = 2,
		ZIPLINE_UP = 3,
		CLIMB_BARS = 4,
		SLIDE = 5,
		CLIMB_LEDGE = 6,
		ZIPLINE_DOWN = 7,
		ESCALATOR = 8
	}

	public struct LaunchData
	{
		public readonly Vector3 initialVelocity;

		public readonly float timeToTarget;

		public LaunchData(Vector3 initialVelocity, float timeToTarget)
		{
			this.timeToTarget = default(float);
			this.initialVelocity = default(Vector3);
		}
	}

	public LinkType linkType;

	public int legAgentID;

	public int crabletAgentID;

	[SerializeField]
	private NavMeshLink[] allNavLinks;

	public NavMeshLink navLinkLeg;

	public NavMeshLink navLinkCrab;

	public AgentLinkControl currLinkAgent;

	public bool isOccupied;

	public float agentDot;

	public Vector3 startPosLocal;

	public Vector3 endPosLocal;

	public GameObject rotaterParentObj;

	public Transform edgeTarget;

	public Transform startRayTarget;

	public Transform endRayTarget;

	[Tooltip("Y local length")]
	public float edgeHeight;

	[Tooltip("X local length")]
	public float edgeWidth;

	[Tooltip("Z local length")]
	public float edgeDepth;

	public float chestHeight;

	public float chestDepth;

	public float kneeHeight;

	public float launchHeight;

	public float linkDepth;

	public float launchMag;

	public ConfigurableJoint linkJoint;

	private JointDrive jointDrive;

	public Transform crabTarget;

	[Header("Climb")]
	public bool isObstructed;

	public Transform leftHandTarget;

	public Transform rightHandTarget;

	public Transform leftKneeTarget;

	public Transform rightKneeTarget;

	public Transform leftHandTargetSecondary;

	public Transform rightHandTargetSecondary;

	public Transform headTarget;

	public float destArmTime;

	public Transform chestTargetPrimary;

	public Transform chestTargetSecondary;

	[Header("Slide")]
	public GameObject moverJointObj;

	public Rigidbody moverJointBody;

	public Transform chestPointStart;

	public Transform chestPointGoal;

	public bool ignoreLaunchTarget;

	private Vector3 lastLaunchTargPos;

	public Transform launchTarget;

	public float launchForce;

	public float launchForceMult;

	public float launchTime;

	public float crabJumpForce;

	public bool applyCorrectiveForce;

	public float correctivePerc;

	public Action<Vector3> OnLaunchAction;

	public GameObject playerTargForwObj;

	public GameObject playerTargRevObj;

	public RigManager rigManager;

	public Rigidbody playerPelvisBody;

	public Rigidbody[] playerBodies;

	public MeshRenderer[] colorizedRends;

	public Material explicitMat;

	public Material autoMat;

	public GameObject autoTriggerForwObj;

	public GameObject autoTriggerRevObj;

	private Coroutine launchRoutine;

	public GameObject forwardObj;

	public GameObject reverseObj;

	[SerializeField]
	private float coolDownDuration;

	private float launchableTime;

	public Vector3[] launchLinePoints;

	[Header("Climb Bars")]
	[SerializeField]
	private GameObject[] barObjs;

	public GameObject[] grabObjs;

	[Header("Zip Line")]
	public Transform zipSpawn;

	public GameObject zipStickPrefab;

	public float zipTime;

	public GenGameControl_Trigger zipTrigger;

	public ZipLinkManager zipManager;

	public ZipJointMover zipJointMover;

	public float lerpDistance;

	public TriggerRefProxy currProxy;

	public Vector3 startPoint;

	public Vector3 endPoint;

	public GameObject startRayObj;

	public GameObject endRayObj;

	public Mesh zipStickMesh;

	[Header("Escalator")]
	public Escalator escalator;

	public GameObject moverTargetParent;

	public GameObject moverTarget;

	public Transform startMoveTarget;

	public Transform endMoveTarget;

	public GenGameControl_Trigger compTrigger;

	public ConfigurableJoint headJoint;

	public ConfigurableJoint chestJoint;

	public ConfigurableJoint leftHandJoint;

	public ConfigurableJoint rightHandJoint;

	public ConfigurableJoint leftElbowJoint;

	public ConfigurableJoint rightElbowJoint;

	public ConfigurableJoint leftFootJoint;

	public ConfigurableJoint rightFootJoint;

	public ConfigurableJoint leftKneeJoint;

	public ConfigurableJoint rightKneeJoint;

	public Color chestColor;

	private static Color headColor;

	private static Color leftHandColor;

	private static Color rightHandColor;

	private static Color leftElbowColor;

	private static Color rightElbowColor;

	public GameObject climbingBarsPrefab;

	public LinkDataManager linkDataManager;

	public bool disableOnLinkCompletion;

	private bool isSubbedToJump;

	public bool isDrawingSim;

	public GameObject simLaunchObj;

	[ContextMenu("CreateStartEndPoints")]
	public void CreateStartEndPoints()
	{
	}

	public void SetStartEndPoints()
	{
	}

	[ContextMenu("CreateEdgeObjectsByType")]
	public void CreateEdgeObjectsByType()
	{
	}

	public void CreateSingleEdgeObjects()
	{
	}

	public void CreateSlideObjects()
	{
	}

	public void OffsetBarGrabObjects()
	{
	}

	private void CreateJumpObjects()
	{
	}

	private void CreateLaunchObjects()
	{
	}

	private void CreateClimbBarObjects()
	{
	}

	private void CreateZipObjects()
	{
	}

	public void CreateMoverJoint()
	{
	}

	public void RotateLinkTargets(bool isForward)
	{
	}

	public float CheckAgentDot(GameObject agentObj)
	{
		return default(float);
	}

	public void LaunchAudio(bool isForw)
	{
	}

	public void ToggleBiDirectional()
	{
	}

	public void OnZipOccupied()
	{
	}

	public void ClaimLink(AgentLinkControl currAgent)
	{
	}

	public void ReleaseLink()
	{
	}

	public void TogglePlayerTarget(bool enable)
	{
	}

	public void PlayerAttack()
	{
	}

	[ContextMenu("GetAllPlayerBodies")]
	public void GetAllPlayerBodies()
	{
	}

	public void LaunchPlayer(float jumpCharge = 1.1f)
	{
	}

	private IEnumerator CoLaunch(float pDot, float timeToTarg)
	{
		return null;
	}

	private void ApplyCorrectiveForce(float playerDot)
	{
	}

	public LaunchData CalculateLaunchData(GameObject launchObj, float height, float gravity)
	{
		return default(LaunchData);
	}

	public TrajectoryData CalcInitialVelocity(GameObject launchObj, Vector3 target, float height)
	{
		return null;
	}

	private IEnumerator CoLaunchSequence(GameObject triggerObj)
	{
		return null;
	}

	public void EnableTrajectoryHelper(GameObject triggerObj)
	{
	}

	public void DisableTrajectoryHelper()
	{
	}

	public void SubToPlayerJump(bool enable)
	{
	}

	public void OnDrawGizmosSelected()
	{
	}

	public LinkData()
		: base()
	{
	}
}
