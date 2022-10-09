using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private Shader shader;

	[SerializeField]
	private float DissolveTime;

	private void Reset()
	{
	}

	public void Dissolve()
	{
	}

	private IEnumerator Dissolver()
	{
		return null;
	}

	public DissolveEffect()
		: base()
	{
	}
}
