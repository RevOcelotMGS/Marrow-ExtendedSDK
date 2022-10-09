using SLZ.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Boneworks
{
	public class AttackReceiver_TimeSlow : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public ChristmasTree controlEnvironment;

		public int targetNumber_Up;

		public int targetNumber_Down;

		private void Start()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public AttackReceiver_TimeSlow()
			: base()
		{
		}
	}
}
