using UnityEngine;

namespace SLZ.Data
{
	[CreateAssetMenu(fileName = "NewHandPoseData", menuName = "StressLevelZero/HandPoseData", order = 1)]
	public class HandPoseData : ScriptableObject
	{
		public Quaternion hand2;

		public Vector3 handleInHandPos;

		public Quaternion handleInHandRot;

		public Quaternion thumb1;

		public Vector3 thumb23;

		public Quaternion index1;

		public Vector3 index23;

		public Quaternion middle1;

		public Vector3 middle23;

		public Quaternion ring1;

		public Vector3 ring23;

		public Quaternion pinky1;

		public Vector3 pinky23;

		public HandPoseData()
			: base()
		{
		}
	}
}
