using UnityEngine;

public class BezierRing : MonoBehaviour
{
	[SerializeField]
	public Transform[] points;

	private LineRenderer Liner;

	public int lineSteps;

	public int CurveCount
	{
		get
		{
			return default(int);
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	public void OnWillRenderObject()
	{
	}

	public void UpdateLines()
	{
	}

	public BezierRing()
		: base()
	{
	}
}
