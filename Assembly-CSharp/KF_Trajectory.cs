using UnityEngine;

public class KF_Trajectory : MonoBehaviour
{
	public Transform target;

	public float height;

	public Rigidbody rb;

	[ContextMenu("Launch")]
	public void Launch()
	{
	}

	public TrajectoryData CalcInitialVelocity()
	{
		return null;
	}

	public KF_Trajectory()
		: base()
	{
	}
}
