using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Volume))]
public class FadeAndDespawnVolume : SpawnEvents
{
	private static ComponentCache<FadeAndDespawnVolume> _cache;

	public Volume volume;

	public Action onComplete;

	public float duration;

	private float startValue;

	private float endValue;

	public GameObject fadingQuad;

	private Material mat;

	private Color black;

	private Color clear;
}
