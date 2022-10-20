using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[AddComponentMenu("Marrow SDK/Generic Grip")]
	public class GenericGripProxy : GripProxy
	{
		[InspectorDisplayName("MeshCollider")]
		[SerializeField]
		[Header("Required Settings")]
		private MeshCollider _proxyMeshCollider;

		public MeshCollider MeshCollider
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

		public GenericGripProxy()
			: base()
		{
		}
	}
}
