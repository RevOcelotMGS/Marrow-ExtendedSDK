using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[AddComponentMenu("Marrow SDK/Barrel Grip")]
	public class BarrelGripProxy : GripProxy
	{
		[InspectorDisplayName("CapsuleCollider")]
		[SerializeField]
		[Header("Required Settings")]
		private CapsuleCollider _proxyCapsuleCollider;

		public CapsuleCollider CapsuleCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void SetupProperties()
		{
		}

		public BarrelGripProxy()
			: base()
		{
		}
	}
}
