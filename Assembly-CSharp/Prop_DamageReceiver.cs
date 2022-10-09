using SLZ.Combat;
using SLZ.Props;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CollisionEnterSensor))]
public class Prop_DamageReceiver : MonoBehaviour, ICollisonReceiver, IEventSystemHandler, IAttackReceiver
{
	[HideInInspector]
	public Prop_Health p_health;

	public void ReceiveAttack(Attack attack)
	{
	}

	public void ReceiveCollison(Collision collision, float relVelocitySqr, bool isStay = false)
	{
	}

	public Prop_DamageReceiver()
		: base()
	{
	}
}
