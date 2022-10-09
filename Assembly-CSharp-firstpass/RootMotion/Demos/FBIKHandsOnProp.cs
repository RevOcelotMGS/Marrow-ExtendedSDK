using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class FBIKHandsOnProp : MonoBehaviour
	{
		public FullBodyBipedIK ik;

		public bool leftHanded;

		private void Awake()
		{
		}

		private void OnPreRead()
		{
		}

		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		private void OnDestroy()
		{
		}

		public FBIKHandsOnProp()
			: base()
		{
		}
	}
}
