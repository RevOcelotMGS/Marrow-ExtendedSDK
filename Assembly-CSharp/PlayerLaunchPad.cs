using System;
using SLZ.Rig;
using UnityEngine;

public class PlayerLaunchPad : MonoBehaviour
{
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

	public RigManager rigManager;

	public Rigidbody[] playerBodies;

	public Rigidbody playerPelvisBody;

	public float launchableTime;

	public float coolDownDuration;

	public float agentDot;

	public float launchForceMult;

	public Transform launchTarget;

	public float linkDepth;

	public Action<Vector3> OnLaunchAction;

	public AudioClip launchClip;

	public void SubToPlayerJump(bool enable)
	{
	}

	public float CheckAgentDot(GameObject agentObj)
	{
		return default(float);
	}

	[ContextMenu("GetAllPlayerBodies")]
	public void GetAllPlayerBodies()
	{
	}

	public void LaunchPlayer(float jumpCharge = 1.1f)
	{
	}

	public LaunchData CalculateLaunchData(GameObject launchObj, float height, float gravity)
	{
		return default(LaunchData);
	}

	public void LaunchAudio()
	{
	}

	public void OnDrawGizmosSelected()
	{
	}

	public PlayerLaunchPad()
		: base()
	{
	}
}
