using UnityEngine;

public class SmoothFollower : MonoBehaviour
{
	public Transform targetTransform;

	public float TranslationSmoothTime;

	public float RotationalSmoothTime;

	private Vector3 velocity;

	private Quaternion quatVel;

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public static Quaternion AngVelToDeriv(Quaternion Current, Vector3 AngVel)
	{
		return default(Quaternion);
	}

	public static Vector3 DerivToAngVel(Quaternion Current, Quaternion Deriv)
	{
		return default(Vector3);
	}

	public static Quaternion IntegrateRotation(Quaternion Rotation, Vector3 AngularVelocity, float DeltaTime)
	{
		return default(Quaternion);
	}

	public static Quaternion SmoothDamp(Quaternion rot, Quaternion target, Quaternion deriv, float time)
	{
		return default(Quaternion);
	}

	public SmoothFollower()
		: base()
	{
	}
}
