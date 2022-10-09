using SLZ.Marrow.Data;
using UnityEngine;

[CreateAssetMenu(fileName = "Arena_EnemyProfile", menuName = "StressLevelZero / NPC_Profile", order = 1)]
public class EnemyProfile : ScriptableObject
{
	public string enemyTitle;

	public Spawnable spawnable;

	public Texture iconImage;

	public bool isKing;

	[HideInInspector]
	public bool showEnemy;

	public int deathMult;

	public float entranceTimeVal;

	public EnemyProfile()
		: base()
	{
	}
}
