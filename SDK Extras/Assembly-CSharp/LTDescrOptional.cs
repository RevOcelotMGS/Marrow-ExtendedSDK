using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LTDescrOptional
{
	public AnimationCurve animationCurve;

	public int initFrameCount;

	public Color color;

	public Transform toTrans { get; set; }

	public Vector3 point { get; set; }

	public Vector3 axis { get; set; }

	public float lastVal { get; set; }

	public Quaternion origRotation { get; set; }

	public LTBezierPath path { get; set; }

	public LTSpline spline { get; set; }

	public LTRect ltRect { get; set; }

	public Action<float> onUpdateFloat { get; set; }

	public Action<float, float> onUpdateFloatRatio { get; set; }

	public Action<float, object> onUpdateFloatObject { get; set; }

	public Action<Vector2> onUpdateVector2 { get; set; }

	public Action<Vector3> onUpdateVector3 { get; set; }

	public Action<Vector3, object> onUpdateVector3Object { get; set; }

	public Action<Color> onUpdateColor { get; set; }

	public Action<Color, object> onUpdateColorObject { get; set; }

	public Action onComplete { get; set; }

	public Action<object> onCompleteObject { get; set; }

	public object onCompleteParam { get; set; }

	public object onUpdateParam { get; set; }

	public Action onStart { get; set; }

	public void reset()
	{
	}

	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	public LTDescrOptional()
		: base()
	{
	}
}
