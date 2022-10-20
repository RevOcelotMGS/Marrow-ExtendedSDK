using SLZ.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Props
{
	public class CollisionCheck : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public void Awake()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public void FixedUpdate()
		{
		}

		public void OnCollisionEnter(Collision impact)
		{
		}

		public void OnCollisionStay(Collision collision)
		{
		}

		public void OnCollisionEXIT(Collision collision)
		{
		}

		public CollisionCheck()
			: base()
		{
		}
	}
}
