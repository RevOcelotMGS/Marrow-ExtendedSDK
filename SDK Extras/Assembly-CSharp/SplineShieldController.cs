using SLZ.Marrow.Interaction;
using UnityEngine;

public class SplineShieldController : MonoBehaviour
{
	[SerializeField]
	private SplineJoint[] sJoints;

	[SerializeField]
	private float innerForce;

	[ContextMenu("SetShieldVelocities")]
	public void SetShieldVels()
	{
	}

	[ContextMenu("StopShields")]
	public void StopShields()
	{
	}

	public void DestroyShieldJoints()
	{
	}

	public SplineShieldController()
		: base()
	{
	}
}
