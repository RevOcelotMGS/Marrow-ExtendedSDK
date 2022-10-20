using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class RigidbodySettingsProxy : BoneProxy
	{
		[InspectorDisplayName("Center Of Mass")]
		[SerializeField]
		private Transform _proxyCenterOfMass;

		public Transform CenterOfMass
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

		public RigidbodySettingsProxy()
			: base()
		{
		}
	}
}
