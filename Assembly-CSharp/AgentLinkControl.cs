using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.AI;

public class AgentLinkControl : MonoBehaviour
{
	public enum LinkState
	{
		SEARCHING = 0,
		WAITING = 1,
		LINKING = 2
	}

	private static ComponentCache<AgentLinkControl> _cache;

	private bool isDebugging;

	private bool isDisplayingDist;

	private bool isDebuggingFallenState;

	[SerializeField]
	[Header("Agent Data")]
	private float totalMass;

	[SerializeField]
	private float jointForceMult;

	private float defaultTotalMass;

	public NavMeshAgent navAgent;

	[SerializeField]
	private AIBrain brain;

	public TriggerRefProxy triggerProxy;

	[SerializeField]
	private GameObject frozenCrabJumpTargetObj;

	public LinkState linkState;

	public bool isOnLink;

	public bool isZipping;

	public float agentDot;

	[SerializeField]
	private float yDiff;

	public Spawnable zipStickSpawn;

	public GameObject zipStick;

	public Rigidbody zipGripBody;

	[SerializeField]
	[Header("Link Data")]
	private UnityEngine.Object owner;

	[SerializeField]
	private NavMeshLink currLink;

	[SerializeField]
	private LinkData currLinkData;

	[SerializeField]
	private LinkData prevFailedLink;

	private Coroutine searchRoutine;

	private Coroutine climbRoutine;

	private Coroutine jumpRoutine;

	private Coroutine launchRoutine;

	private Coroutine climbBarsRoutine;

	private Coroutine slideRoutine;

	private Coroutine climbLedgeRoutine;

	private Coroutine zipRoutine;

	private Coroutine reverseZipRoutine;

	private Coroutine occupiedRoutine;

	private Coroutine distRoutine;

	private Coroutine fallenRoutine;

	private Coroutine escalatorRoutine;

	[Header("Rigidbodies")]
	[SerializeField]
	public Rigidbody headRB;

	[SerializeField]
	public Rigidbody chestRB;

	[SerializeField]
	private Rigidbody leftHandRB;

	[SerializeField]
	private Rigidbody leftElbowRB;

	[SerializeField]
	private Rigidbody rightHandRB;

	[SerializeField]
	private Rigidbody rightElbowRB;

	[SerializeField]
	private Rigidbody leftFootRB;

	[SerializeField]
	private Rigidbody leftKneeRB;

	[SerializeField]
	private Rigidbody rightFootRB;

	[SerializeField]
	private Rigidbody rightKneeRB;

	public Rigidbody[] allRBs;

	[Header("Joints")]
	[SerializeField]
	private ConfigurableJoint headJoint;

	[SerializeField]
	private ConfigurableJoint chestJoint;

	[SerializeField]
	private ConfigurableJoint leftElbowJoint;

	[SerializeField]
	private ConfigurableJoint rightElbowJoint;

	[SerializeField]
	private ConfigurableJoint leftHandJoint;

	[SerializeField]
	private ConfigurableJoint rightHandJoint;

	[SerializeField]
	private ConfigurableJoint leftKneeJoint;

	[SerializeField]
	private ConfigurableJoint rightKneeJoint;

	[SerializeField]
	private ConfigurableJoint leftFootJoint;

	[SerializeField]
	private ConfigurableJoint rightFootJoint;

	private JointDrive kneeDrive;

	private JointDrive footDrive;

	private JointDrive handDrive;

	private JointDrive chestDrive;

	private JointDrive headDrive;

	private int crabletAgentID;

	public TriggerRefProxy playerProxy;

	[SerializeField]
	[Header("Distance Covered")]
	private Vector3 initialPos;

	[SerializeField]
	private float sqrPos;

	[SerializeField]
	private float distTimer;

	private Color agentColor;

	public static ComponentCache<AgentLinkControl> Cache
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator CoSearchForLink()
	{
		return null;
	}

	private IEnumerator CoTriggerLink()
	{
		return null;
	}

	[ContextMenu("Reset Agent Path")]
	public void ResetAgent()
	{
	}

	public void ResetDistRoutine()
	{
	}

	public void StopDistRoutines()
	{
	}

	private void SetLinkState(LinkState state)
	{
	}

	private void StartLinkByType()
	{
	}

	private IEnumerator CoWaitForOccupation()
	{
		return null;
	}

	private IEnumerator CoClimbBlock(float obstructionWait = 10f)
	{
		return null;
	}

	private void LaunchArm()
	{
	}

	private IEnumerator CoJump(float seconds)
	{
		return null;
	}

	private IEnumerator CoLaunch(float linkDuration)
	{
		return null;
	}

	private IEnumerator CoOmniJumpDown(float seconds)
	{
		return null;
	}

	private IEnumerator CoClimbBars()
	{
		return null;
	}

	private IEnumerator CoSlide()
	{
		return null;
	}

	private IEnumerator CoClimbLedge()
	{
		return null;
	}

	private IEnumerator CoZipLineDown()
	{
		return null;
	}

	private IEnumerator CoZipLineUp()
	{
		return null;
	}

	private IEnumerator CoEscalate()
	{
		return null;
	}

	private IEnumerator CoDistCovered()
	{
		return null;
	}

	private IEnumerator CoCheckLegsFallenState()
	{
		return null;
	}

	private IEnumerator CoCheckCrabFallenState()
	{
		return null;
	}

	private void OnProxyEnter(TriggerRefProxy proxy)
	{
	}

	public void DetachDownZip()
	{
	}

	public void DetachUpZip()
	{
	}

	private void CreateJumpTarget()
	{
	}

	private IEnumerator CoCrabJumpAttempt()
	{
		return null;
	}

	private IEnumerator CoCrabZip()
	{
		return null;
	}

	private void FailLink()
	{
	}

	private void CompleteLink()
	{
	}

	private void ReleaseLinkAndJoints()
	{
	}

	private void StopAllLinkRoutines()
	{
	}

	private void OnDeath()
	{
	}

	private IEnumerator CoDespawnDeadEscalator()
	{
		return null;
	}

	private void DestroyHandJoints()
	{
	}

	private void DestroyLeftArmJoints()
	{
	}

	private void DestroyRightArmJoints()
	{
	}

	private void DestroyArmJoints()
	{
	}

	private void DestroyLegJoints()
	{
	}

	private void DestroyAllJoints()
	{
	}

	private void DestroyHeadJoint()
	{
	}

	private void DestroyChestJoint()
	{
	}

	private bool CheckYDist(float maxVal)
	{
		return default(bool);
	}

	public void StopAllRoutinesAndDisable()
	{
	}

	[ContextMenu("GetAgentRefs")]
	public void GetAgentRefs()
	{
	}

	[ContextMenu("GetAllRigidbodies")]
	public void GetAllRigidbodies()
	{
	}

	[ContextMenu("GetTotalMass")]
	public void GetTotalMass()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public AgentLinkControl()
		: base()
	{
	}
}
