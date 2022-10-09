using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

namespace PuppetMasta
{
	public abstract class Prop : MonoBehaviour
	{
		[Tooltip("This has no other purpose but helping you distinguish props by PropRoot.currentProp.propType.")]
		public int propType;

		[Tooltip("The Muscle of this prop.")]
		[LargeHeader("Muscle")]
		public ConfigurableJoint muscle;

		[Tooltip("The muscle properties that will be applied to the Muscle on pickup.")]
		public Muscle.Props muscleProps;

		[Tooltip("If true, this prop's layer will be forced to PuppetMaster layer and target's layer forced to PuppetMaster's Target Root's layer when the prop is picked up.")]
		public bool forceLayers;

		[LargeHeader("Additional Pin")]
		[Tooltip("Optinal additional pin, useful for long melee weapons that would otherwise require a lot of muscle force and solver iterations to be swinged quickly. Should normally be without any colliders attached. The position of the pin, it's mass and the pin weight will effect how the prop will handle.")]
		public ConfigurableJoint additionalPin;

		[Tooltip("Target Transform for the additional pin.")]
		public Transform additionalPinTarget;

		[Tooltip("The pin weight of the additional pin. Increasing this weight will make the prop follow animation better, but will increase jitter when colliding with objects.")]
		[Range(0f, 1f)]
		public float additionalPinWeight;

		private ConfigurableJointMotion xMotion;

		private ConfigurableJointMotion yMotion;

		private ConfigurableJointMotion zMotion;

		private ConfigurableJointMotion angularXMotion;

		private ConfigurableJointMotion angularYMotion;

		private ConfigurableJointMotion angularZMotion;

		private Collider[] colliders;

		public bool isPickedUp
		{
			get
			{
				return default(bool);
			}
		}

		public PropRoot propRoot { get; private set; }

		public void PickUp(PropRoot propRoot)
		{
		}

		public void Drop()
		{
		}

		public void StartPickedUp(PropRoot propRoot)
		{
		}

		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		protected virtual void OnDrop()
		{
		}

		protected virtual void OnStart()
		{
		}

		private void Start()
		{
		}

		private void ReleaseJoint()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public Prop()
			: base()
		{
		}
	}
}
