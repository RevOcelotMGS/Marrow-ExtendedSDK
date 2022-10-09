using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class ImpactProperties : ImpactPropertiesVariables, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<ImpactProperties> _cache;

		[Header("References")]
		public Collider[] colliders;

		[HideInInspector]
		[SerializeField]
		public bool hasManager;

		[SerializeField]
		[HideInInspector]
		public bool ShowControls;

		[SerializeField]
		[HideInInspector]
		public ImpactPropertiesManager Manager;

		private bool setup;

		public static ComponentCache<ImpactProperties> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void StaticFix()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateMaterial()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public UniTaskVoid RecieveAttackAsync(Attack attack)
		{
			return default(UniTaskVoid);
		}

		public void SpawnImpactVFX(Attack attack)
		{
		}

		public void FindColliders(bool childColliders = false)
		{
		}

		public void FindRenderer()
		{
		}

		private void SetRenderer(Renderer renderer)
		{
		}

		public float GetMegaPascals()
		{
			return default(float);
		}

		public ImpactProperties()
			: base()
		{
		}
	}
}
