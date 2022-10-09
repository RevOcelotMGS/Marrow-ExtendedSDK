using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class BendGoal : MonoBehaviour
	{
		public LimbIK limbIK;

		[Range(0f, 1f)]
		public float weight;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public BendGoal()
			: base()
		{
		}
	}
}
