using UnityEngine;

public class HoverEngine : MonoBehaviour
{
	public LayerMask RaycastMask;

	public float MaxHeight;

	public float GroundForce;

	public float Damping;

	public float Exponent;

	public float MaxAngleDrift;

	public Rigidbody Rigidbody;

	private float m_LastPower;

	private RaycastHit m_GroundHit;

	public bool HasGround
	{
		get
		{
			return default(bool);
		}
	}

	public float Power
	{
		get
		{
			return default(float);
		}
	}

	public RaycastHit Ground
	{
		get
		{
			return default(RaycastHit);
		}
	}

	private void FixedUpdate()
	{
	}

	public HoverEngine()
		: base()
	{
	}
}
