using System;
using SLZ.AI;
using SLZ.Zones;
using UnityEngine;

[Serializable]
public class NPC_Data
{
	public SceneZone sZone;

	public ZoneSpawner zSpawner;

	public AIBrain aiBrain;

	public AgentLinkControl agentLinkControl;

	public TriggerRefProxy myProxy;

	public TriggerRefProxy targetProxy;

	public EnemyProfile enemyProfile;

	public NPC_Objective NPC_objective;

	public int spawnOrder;

	public bool isDead;

	public bool isDespawned;

	public bool isFriendly;

	public bool isKing;

	public GameObject crownObj;

	public FixedJoint crownJoint;

	public Texture iconImage;

	public Vector3 _position;

	public float deathTime;

	public NPC_Data()
		: base()
	{
	}
}
