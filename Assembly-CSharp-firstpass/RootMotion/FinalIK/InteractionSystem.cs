using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Header("Triggering")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		public Collider characterCollider;

		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		private List<InteractionTrigger> inContact;

		private List<int> bestRangeIndexes;

		public InteractionDelegate OnInteractionStart;

		public InteractionDelegate OnInteractionPause;

		public InteractionDelegate OnInteractionPickUp;

		public InteractionDelegate OnInteractionResume;

		public InteractionDelegate OnInteractionStop;

		public InteractionEventDelegate OnInteractionEvent;

		public RaycastHit raycastHit;

		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		private InteractionEffector[] interactionEffectors;

		private bool initiated;

		private Collider lastCollider;

		private Collider c;

		public bool inInteraction
		{
			get
			{
				return default(bool);
			}
		}

		public FullBodyBipedIK ik
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<InteractionTrigger> triggersInRange { get; private set; }

		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		public bool IsPaused()
		{
			return default(bool);
		}

		public bool IsInSync()
		{
			return default(bool);
		}

		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		public void PauseAll()
		{
		}

		public void ResumeAll()
		{
		}

		public void StopAll()
		{
		}

		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		public float GetMinActiveProgress()
		{
			return default(float);
		}

		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		public bool TriggerInteraction(int index, bool interrupt, [Out] InteractionObject interactionObject)
		{
			return default(bool);
		}

		public bool TriggerInteraction(int index, bool interrupt, [Out] InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		private void Start()
		{
		}

		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		public void OnTriggerEnter(Collider c)
		{
		}

		public void OnTriggerExit(Collider c)
		{
		}

		private bool ContactIsInRange(int index, [Out] int bestRangeIndex)
		{
			return default(bool);
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void Update()
		{
		}

		private void Raycasting()
		{
		}

		private void UpdateTriggerEventBroadcasting()
		{
		}

		private void UpdateEffectors()
		{
		}

		private void OnPreFBBIK()
		{
		}

		private void OnPostFBBIK()
		{
		}

		private void OnFixTransforms()
		{
		}

		private void OnDestroy()
		{
		}

		private bool IsValid(bool log)
		{
			return default(bool);
		}

		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		public InteractionSystem()
			: base()
		{
		}
	}
}
