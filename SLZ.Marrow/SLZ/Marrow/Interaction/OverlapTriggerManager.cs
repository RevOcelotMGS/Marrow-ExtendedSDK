using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class OverlapTriggerManager
	{
		private enum EventType
		{
			TriggerEnter = 0,
			TriggerExit = 1
		}

		private readonly Dictionary<GameObject, Dictionary<GameObject, int>> _overlapCounts;

		private readonly Dictionary<GameObject, HashSet<GameObject>> _helperPairLookup;

		/*[TupleElementNames(new string[] { "type", "trigger", "gameObject" })]
		private readonly List<ValueTuple<EventType, OverlapTrigger, GameObject>> _triggerEvents;*/

		~OverlapTriggerManager()
		{
		}

		public void AddOverlapEnterPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		public void AddOverlapExitPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		public void DisableOverlap(GameObject overlapObject)
		{
		}

		private void ClearPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		private void AddHelper(GameObject triggerGameObject, GameObject otherGameObject)
		{
		}

		private void RemoveHelper(GameObject triggerGameObject, GameObject otherGameObject)
		{
		}

		private void OnMarrowUpdate()
		{
		}

		public OverlapTriggerManager()
			: base()
		{
		}
	}
}
