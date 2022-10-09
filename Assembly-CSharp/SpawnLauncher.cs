using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

public class SpawnLauncher : MonoBehaviour
{
	public Spawnable spawnable;

	public Transform firePoint;

	private void Start()
	{
	}

	public UniTaskVoid Spawn()
	{
		return default(UniTaskVoid);
	}

	private void OnSpawn(GameObject go)
	{
	}

	private void DrawBounds(Bounds bounds, Vector3 position, Quaternion rotation)
	{
	}

	public SpawnLauncher()
		: base()
	{
	}
}
