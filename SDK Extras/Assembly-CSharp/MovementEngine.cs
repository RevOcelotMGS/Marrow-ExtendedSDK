using UnityEngine;

public class MovementEngine : MonoBehaviour
{
	public float Thrust;

	public float MaxForwardAcceleration;

	public float MaxReverseAcceleration;

	public float MaxBrakingDeceleration;

	public float AutoBrakingDeceleration;

	public float MaxSpeed;

	public AnimationCurve AccelerationBySpeed;

	public float VerticalReduction;

	public float MaxPitchAngle;

	public Rigidbody Rigidbody;

	public HoverEngine[] HoverEngines;

	private SideDependentDrag m_Drag;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private float GetDrag(float speed)
	{
		return default(float);
	}

	public MovementEngine()
		: base()
	{
	}
}
