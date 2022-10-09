using System;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class MarrowGameObject : MarrowAssetT<GameObject>
	{
		public MarrowGameObject()
			: base()
		{
		}

		public MarrowGameObject(string guid)
			: this()
		{
		}
	}
}
