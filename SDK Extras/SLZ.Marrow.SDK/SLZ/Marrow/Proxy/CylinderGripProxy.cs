using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[AddComponentMenu("Marrow SDK/Cylinder Grip")]
	public class CylinderGripProxy : GripProxy, ISerializationCallbackReceiver
	{
		[Header("Required Settings")]
		[SerializeField]
		[InspectorDisplayName("CapsuleCollider")]
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

		public CylinderGripProxy()
			: base()
		{
		}
	}
}
