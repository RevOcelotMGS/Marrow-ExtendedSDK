using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TransformLerp : MonoBehaviour
{
	public Transform SourceTransform;

	public Transform StartingTransform;

	public Transform EndingTransform;

	public void DoLerpTransform(float time)
	{
	}

	private IEnumerator LerpTransform(float time)
	{
		return null;
	}

	public TransformLerp()
		: base()
	{
	}
}
