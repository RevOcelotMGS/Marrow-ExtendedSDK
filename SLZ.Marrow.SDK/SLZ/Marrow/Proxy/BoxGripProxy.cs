using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[AddComponentMenu("Marrow SDK/Box Grip")]
	public class BoxGripProxy : GripProxy
	{
		[InspectorDisplayName("BoxCollider")]
		[SerializeField]
		[Header("Required Settings")]
		private BoxCollider _proxyBoxCollider;

		public BoxCollider BoxCollider
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

		public BoxGripProxy()
			: base()
		{
		}
	}
}
