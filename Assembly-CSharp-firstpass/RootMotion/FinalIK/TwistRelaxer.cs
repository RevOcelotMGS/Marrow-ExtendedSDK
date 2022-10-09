using UnityEngine;

namespace RootMotion.FinalIK
{
	public class TwistRelaxer : MonoBehaviour
	{
		public IK ik;

		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform child;

		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		private Vector3 twistAxis;

		private Vector3 axis;

		private Vector3 axisRelativeToParentDefault;

		private Vector3 axisRelativeToChildDefault;

		public void Relax()
		{
		}

		private void Start()
		{
		}

		private void OnPostUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public TwistRelaxer()
			: base()
		{
		}
	}
}
