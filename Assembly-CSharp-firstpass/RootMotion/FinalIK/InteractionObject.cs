using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		public class InteractionEvent
		{
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			public void Activate(Transform t)
			{
			}

			public InteractionEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class Message
		{
			[Tooltip("The name of the function called.")]
			public string function;

			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			private const string empty = "";

			public void Send(Transform t)
			{
			}

			public Message()
				: base()
			{
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			private const string empty = "";

			public void Activate(bool pickUp)
			{
			}

			private void Activate(Animator animator)
			{
			}

			private void Activate(Animation animation)
			{
			}

			public AnimatorEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class WeightCurve
		{
			[Serializable]
			public enum Type
			{
				PositionWeight = 0,
				RotationWeight = 1,
				PositionOffsetX = 2,
				PositionOffsetY = 3,
				PositionOffsetZ = 4,
				Pull = 5,
				Reach = 6,
				RotateBoneWeight = 7,
				Push = 8,
				PushParent = 9,
				PoserWeight = 10
			}

			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			public float GetValue(float timer)
			{
				return default(float);
			}

			public WeightCurve()
				: base()
			{
			}
		}

		[Serializable]
		public class Multiplier
		{
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			public Multiplier()
				: base()
			{
			}
		}

		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		public WeightCurve[] weightCurves;

		public Multiplier[] multipliers;

		public InteractionEvent[] events;

		private InteractionTarget[] targets;

		public float length { get; private set; }

		public InteractionSystem lastUsedInteractionSystem { get; private set; }

		public Transform lookAtTarget
		{
			get
			{
				return null;
			}
		}

		public Transform targetsRoot
		{
			get
			{
				return null;
			}
		}

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

		public void Initiate()
		{
		}

		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		private void Awake()
		{
		}

		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		public InteractionObject()
			: base()
		{
		}
	}
}
