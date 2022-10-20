using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ
{
	public class SplineJointSpawnableEmitter : SplineEntity
	{
		public enum Mode
		{
			Manual = 0,
			Once = 1,
			Multiple = 2
		}

		[Header("Settings")]
		public Spawnable splineSpawnable;

		public Mode mode;

		public float delay;

		public float frequency;

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		private UniTaskVoid SpawnLoop()
		{
			return default(UniTaskVoid);
		}

		public void Spawn()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public SplineJointSpawnableEmitter()
			: base()
		{
		}
	}
}
