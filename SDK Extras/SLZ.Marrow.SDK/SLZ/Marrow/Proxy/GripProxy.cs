using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public abstract class GripProxy : BoneProxy
	{
		[InspectorDisplayName("AdditionalGripColliders")]
		private List<Collider> _proxyAdditionalGripColliders;

		public List<Collider> AdditionalGripColliders
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

		public GripProxy()
			: base()
		{
		}
	}
}
