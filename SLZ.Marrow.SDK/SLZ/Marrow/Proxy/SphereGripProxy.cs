using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[AddComponentMenu("Marrow SDK/Sphere Grip")]
	public class SphereGripProxy : GripProxy
	{
		[InspectorDisplayName("SphereCollider")]
		[Header("Required Settings")]
		[SerializeField]
		private SphereCollider _proxySphereCollider;

		public SphereCollider SphereCollider
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

		public SphereGripProxy()
			: base()
		{
		}
	}
}
