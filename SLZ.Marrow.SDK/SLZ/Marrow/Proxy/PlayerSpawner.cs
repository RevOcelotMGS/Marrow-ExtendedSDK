using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.Proxy
{
	public class PlayerSpawner : BoneProxy
	{
		[SerializeField]
		public UnityAction<Vector3> TeleportAction;

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[ContextMenu("Teleport")]
		public void Teleport(Vector3 pos)
		{
		}

		public void Teleport(Transform tran)
		{
		}

		protected override void SetupProperties()
		{
		}

		public PlayerSpawner()
			: base()
		{
		}
	}
}
