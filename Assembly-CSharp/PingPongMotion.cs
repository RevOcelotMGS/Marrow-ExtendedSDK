using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

public class PingPongMotion : MonoBehaviour
{
	public enum MoveAxis
	{
		x = 0,
		y = 1,
		z = 2
	}

	public enum PingPongMode
	{
		ease = 0,
		hardStop = 1,
		bounce = 2
	}

	[Tooltip("Required to have the same parent object as the Moving Object")]
	public GameObject reversePointPositive;

	[Tooltip("Required to have the same parent object as the Moving Object")]
	public GameObject reversePointNegative;

	[Tooltip("Rigid body of object that is moving")]
	[InspectorDisplayName("Rigid Body")]
	public Rigidbody rb;

	[Tooltip("Configurable Joint of object that is moving")]
	[InspectorDisplayName("Configurable Joint")]
	public ConfigurableJoint configJoint;

	[Tooltip("Power Source node you intend to have power change between")]
	[InspectorDisplayName("Mini Power Source Node")]
	public SourceNode mpsn;

	[Tooltip("Local Axis that you want to check the motion against, the actual local axis, not the configurable joint's axis")]
	public MoveAxis selectedAxis;

	[Tooltip("Ease: flips motor value, easing out of motion.  Will over shoot.    Hard Stop: kills velocity at turn point. Will ease back into motion.    Bounce: inverts velocity at turn point to conserve momentum.")]
	public PingPongMode mode;

	[HideInInspector]
	private float _reversePositive;

	[HideInInspector]
	private float _reverseNegative;

	private float _powerState;

	private float _cachedState;

	private void Reset()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private bool CheckBounds()
	{
		return default(bool);
	}

	public void ReverseMotion()
	{
	}

	public void StartPositive()
	{
	}

	public void StartNegative()
	{
	}

	public void ResumeMotion()
	{
	}

	public void StopMotion()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public PingPongMotion()
		: base()
	{
	}
}
