using SLZ.Zones;
using UnityEngine;

public class Escalator : ZoneItem
{
	public float resetHalfThreshold;

	[SerializeField]
	private float _speed;

	[SerializeField]
	private float _lastSpeed;

	public Rigidbody steps;

	public ConfigurableJoint topTransiton;

	public ConfigurableJoint topPlatform;

	public ConfigurableJoint botTransiton;

	public ConfigurableJoint botPlatform;

	public Transform beltRail;

	public Transform topRail;

	public Transform botRail;

	public Rigidbody topPlatRoll;

	public Rigidbody botPlatRoll;

	public Rigidbody topTranRoll;

	public Rigidbody botTranRoll;

	private ConfigurableJoint _stepsJoint;

	public Transform materialMill;

	private Material _matMill;

	public Vector2 directionMill;

	private Quaternion topPlatRollInit;

	private Quaternion botPlatRollInit;

	private Quaternion topTranRollInit;

	private Quaternion botTranRollInit;

	private Rigidbody _topTranRb;

	private Rigidbody _botTranRb;

	private float _lastCycle;

	public float speed;

}
