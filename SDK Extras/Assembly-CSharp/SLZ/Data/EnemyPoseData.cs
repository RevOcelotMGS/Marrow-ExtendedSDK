using UnityEngine;

namespace SLZ.Data
{
	[CreateAssetMenu(fileName = "NewEnemyPoseData", menuName = "StressLevelZero/EnemyPoseData", order = 2)]
	public class EnemyPoseData : ScriptableObject
	{
		public Vector3[] posePositions;

		public Quaternion[] poseRotations;

		public EnemyPoseData()
			: base()
		{
		}
	}
}
