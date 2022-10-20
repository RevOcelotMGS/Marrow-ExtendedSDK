using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public interface IAttackReceiver : IEventSystemHandler
	{
		void ReceiveAttack(Attack attack);
	}
}
