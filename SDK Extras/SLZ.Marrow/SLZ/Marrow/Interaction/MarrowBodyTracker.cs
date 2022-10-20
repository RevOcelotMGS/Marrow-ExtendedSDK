using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class MarrowBodyTracker : MonoBehaviour
	{
		public MarrowEntity entity;

		public MarrowBody body;

		public BoxCollider trigger;

		public MarrowBodyTracker()
			: base()
		{
		}
	}
}
