using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		public class EffectorLink
		{
			public bool enabled;

			public FullBodyBipedEffector effectorType;

			public InteractionObject interactionObject;

			public Transform spherecastFrom;

			public float spherecastRadius;

			public float minDistance;

			public LayerMask touchLayers;

			public float lerpSpeed;

			public float minSwitchTime;

			public float releaseDistance;

			public bool sliding;

			private Vector3 raycastDirectionLocal;

			private float raycastDistance;

			private bool inTouch;

			private RaycastHit hit;

			private Vector3 targetPosition;

			private Quaternion targetRotation;

			private bool initiated;

			private float nextSwitchTime;

			private float speedF;

			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			public void Update(InteractionSystem interactionSystem)
			{
			}

			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			public EffectorLink()
				: base()
			{
			}
		}

		public InteractionSystem interactionSystem;

		public EffectorLink[] effectorLinks;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public TouchWalls()
			: base()
		{
		}
	}
}
