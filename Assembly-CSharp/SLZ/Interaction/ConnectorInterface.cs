using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	[CreateAssetMenu(fileName = "ConnectorInterface", menuName = "Marrow/ConnectorInterface", order = 1)]
	public class ConnectorInterface : ScriptableObject
	{
		public virtual bool IsCompatibleWith(ConnectorInterface other)
		{
			return default(bool);
		}

		public virtual float Validate(Connector connectorA, Connector connectorB)
		{
			return default(float);
		}

		public virtual SimpleTransform Solve(Connector connectorA, Connector connectorB)
		{
			return default(SimpleTransform);
		}

		public ConnectorInterface()
			: base()
		{
		}
	}
}
