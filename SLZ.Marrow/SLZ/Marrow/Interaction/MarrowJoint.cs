using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class MarrowJoint : MarrowBehaviour
	{
		private static ComponentCache<MarrowJoint> _cache;

		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		[SerializeField]
		private MarrowBody _connectedMarrowBody;

		[SerializeField]
		private ConfigurableJointInfo _configurableJointSettings;

		[SerializeField]
		private MarrowEntity _parent;

		private ConfigurableJointInfo _cjFreezeInfo;

		public static ComponentCache<MarrowJoint> Cache
		{
			get
			{
				return null;
			}
		}

		public bool HasConfigJoint { get; private set; }

		public void ResetConfig()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public bool TryGetConfigurableJoint([Out] ConfigurableJoint joint)
		{
			return default(bool);
		}

		public void DestroyConfigurableJoint()
		{
		}

		public void CreateConfigurableJoint()
		{
		}

		public MarrowJoint()
			: base()
		{
		}
	}
}
