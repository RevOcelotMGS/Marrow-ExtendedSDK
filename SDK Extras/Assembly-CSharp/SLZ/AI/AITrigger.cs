using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.AI
{
	public class AITrigger : MonoBehaviour
	{
		public TriggerManager.TriggerTypes type;

		public float radius;

		public float fov;

		public Action<AITarget> onTriggerEnter;

		public Action<AITarget> onTriggerExit;

		public void SetTrigger(float? radius = default(float?), float? fov = default(float?), TriggerManager.TriggerTypes? type = default(TriggerManager.TriggerTypes?))
		{
		}

		public bool TryGetTargetResult(AITarget target, [Out] TriggerManager.TriggerCompareResult result)
		{
			return default(bool);
		}

		public virtual void OnAITriggerEnter(AITarget target)
		{
		}

		public virtual void OnAITriggerExit(AITarget target)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public AITrigger()
			: base()
		{
		}
	}
}
