using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		public class Settings
		{
			[Tooltip("Ankle joint damper / spring. Increase to make the balancing effect softer.")]
			public float damperForSpring;

			[Tooltip("Multiplier for joint max force.")]
			public float maxForceMlp;

			[Tooltip("Multiplier for the inertia tensor. Increasing this will increase the balancing forces.")]
			public float IMlp;

			[Tooltip("Velocity-based prediction.")]
			public float velocityF;

			[Tooltip("World space offset for the center of pressure. Can be used to make the characer lean in a certain direction.")]
			public Vector3 copOffset;

			[Tooltip("The amount of torque applied to the lower legs to help keep the puppet balanced. Note that this is an external force (not coming from the joints themselves) and might make the simulation seem unnatural.")]
			public float torqueMlp;

			[Tooltip("Maximum magnitude of the torque applied to the lower legs if 'Torque Mlp' > 0.")]
			public float maxTorqueMag;

			public Settings()
				: base()
			{
			}
		}

		private Settings settings;

		private Rigidbody[] rigidbodies;

		private Transform[] copPoints;

		private PressureSensor pressureSensor;

		private Rigidbody Ibody;

		private Vector3 I;

		private Quaternion toJointSpace;

		public ConfigurableJoint joint { get; private set; }

		public Vector3 dir { get; private set; }

		public Vector3 dirVel { get; private set; }

		public Vector3 cop { get; private set; }

		public Vector3 com { get; private set; }

		public Vector3 comV { get; private set; }

		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		private void Solve()
		{
		}

		public SubBehaviourBalancer()
			: base()
		{
		}
	}
}
