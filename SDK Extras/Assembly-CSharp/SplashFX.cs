using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

public class SplashFX : MonoBehaviour
{
	public float VelocityThreshold;

	public float ImpulseThreshold;

	public Spawnable SpawnableVFX;

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void ImpactVFX(Collision collision)
	{
	}

	private void Awake()
	{
	}

	public UniTaskVoid RegAsync()
	{
		return default(UniTaskVoid);
	}

	public SplashFX()
		: base()
	{
	}
}
