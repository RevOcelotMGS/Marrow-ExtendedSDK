using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[SerializeField]
		private int GUIspace;

		public InteractionSystem interactionSystem;

		public InteractionObject obj;

		public Transform pivot;

		public Transform holdPoint;

		public float pickUpTime;

		private float holdWeight;

		private float holdWeightVel;

		private Vector3 pickUpPosition;

		private Quaternion pickUpRotation;

		private bool holding
		{
			get
			{
				return default(bool);
			}
		}

		private void OnGUI()
		{
		}

		protected abstract void RotatePivot();

		private void Start()
		{
		}

		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public PickUp2Handed()
			: base()
		{
		}
	}
}
