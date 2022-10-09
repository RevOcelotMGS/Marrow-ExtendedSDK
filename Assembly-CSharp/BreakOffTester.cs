using SLZ.Marrow.Utilities;
using UnityEngine;

public class BreakOffTester : MonoBehaviour
{
	public Transform targetA;

	public Transform targetB;

	public Transform handA;

	public Transform handB;

	public Transform host;

	public Transform hostA;

	public Transform hostB;

	public Transform hand2A;

	public Transform hand2B;

	private Quaternion handleSpace;

	public Vector3 forward;

	public Vector3 up;

	private float _priAngleWindup;

	private float _secAngleWindup;

	private bool _priSnapshot;

	private bool _secSnapshot;

	private Quaternion _priLocalDelta;

	private Quaternion _secLocalDelta;

	private SimpleTransform _truthRig;

	private void Update()
	{
	}

	public BreakOffTester()
		: base()
	{
	}
}
