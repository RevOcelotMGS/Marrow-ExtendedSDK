using UnityEngine;

namespace SLZ.Utilities
{
	public class CollisionLogger : MonoBehaviour
	{
		public bool destroyFallers;

		private void OnCollisionEnter(Collision c)
		{
		}

		public CollisionLogger()
			: base()
		{
		}
	}
}
