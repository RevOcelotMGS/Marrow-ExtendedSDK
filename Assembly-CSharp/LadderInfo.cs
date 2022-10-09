using UnityEngine;

public struct LadderInfo
{
	public enum Source
	{
		LEFTHAND = 0,
		RIGHTHAND = 1,
		FEET = 2
	}

	public Source source;

	public Transform rungTransform;

	public int totalRungs;

	public int rungNumber;

	public float rungWidth;

	public float rungRadius;

	public LadderInfo(Source s, Transform rt, int tr, int tn, float rw, float rr)
	{
		this.rungRadius = default(float);
		this.rungWidth = default(float);
		this.rungNumber = default(int);
		this.totalRungs = default(int);
		this.rungTransform = default(Transform);
		this.source = default(Source);
	}
}
