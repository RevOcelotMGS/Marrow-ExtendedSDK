using UnityEngine;

public class AxisFollow : MonoBehaviour
{
	public enum vectorType
	{
		x = 0,
		y = 1,
		z = 2
	}

	public vectorType VecType;

	[SerializeField]
	private Transform FollowTarget;

	private void Update()
	{
	}

	public AxisFollow()
		: base()
	{
	}
}
