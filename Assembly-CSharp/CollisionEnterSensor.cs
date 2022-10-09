using System.Runtime.CompilerServices;
using SLZ.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollisionEnterSensor : MonoBehaviour
{
	public float minVelocityDeltaSqr;

	private void OnCollisionEnter(Collision c)
	{
	}

	public CollisionEnterSensor()
		: base()
	{
	}
}
