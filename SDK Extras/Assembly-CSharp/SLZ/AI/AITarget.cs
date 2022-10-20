using UnityEngine;

namespace SLZ.AI
{
	public class AITarget : MonoBehaviour
	{
		public TriggerManager.TargetTypes type;

		public float radius;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public AITarget()
			: base()
		{
		}
	}
}
