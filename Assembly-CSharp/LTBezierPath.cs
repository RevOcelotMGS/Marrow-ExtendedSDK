using UnityEngine;

public class LTBezierPath
{
	public Vector3[] pts;

	public float length;

	public bool orientToPath;

	public bool orientToPath2d;

	private LTBezier[] beziers;

	private float[] lengthRatio;

	private int currentBezier;

	private int previousBezier;

	public float distance
	{
		get
		{
			return default(float);
		}
	}

	public LTBezierPath()
		: base()
	{
	}

	public LTBezierPath(Vector3[] pts_)
		: this()
	{
	}

	public void setPoints(Vector3[] pts_)
	{
	}

	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	public void place2d(Transform transform, float ratio)
	{
	}

	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	public void place(Transform transform, float ratio)
	{
	}

	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	public void placeLocal(Transform transform, float ratio)
	{
	}

	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	public void gizmoDraw(float t = -1f)
	{
	}

	public float ratioAtPoint(Vector3 pt, float precision = 0.01f)
	{
		return default(float);
	}
}
