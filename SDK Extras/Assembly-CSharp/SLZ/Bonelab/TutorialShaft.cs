using UnityEngine;

namespace SLZ.Bonelab
{
	public class TutorialShaft : MonoBehaviour
	{
		public enum ShaftState
		{
			STOPPED = 0,
			MOVING_UP = 1,
			MOVING_DOWN = 2
		}

		public TutorialElevator elevator;

		public ShaftState shaftState;

		public float speed;

		public float shaftHeight;

		public float loopHeight;

		private void Update()
		{
		}

		public TutorialShaft()
			: base()
		{
		}
	}
}
