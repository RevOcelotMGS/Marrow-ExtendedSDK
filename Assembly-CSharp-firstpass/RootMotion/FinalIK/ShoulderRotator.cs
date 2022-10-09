using UnityEngine;

namespace RootMotion.FinalIK
{
	public class ShoulderRotator : MonoBehaviour
	{
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		private FullBodyBipedIK ik;

		private bool skip;

		private void Start()
		{
		}

		private void RotateShoulders()
		{
		}

		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public ShoulderRotator()
			: base()
		{
		}
	}
}
