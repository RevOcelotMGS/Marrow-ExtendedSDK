using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Tooltip("Weight of using this effector")]
				public float weight;

				public EffectorLink()
					: base()
				{
				}
			}

			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			private Vector3 lastRelativePos;

			private Vector3 smoothDelta;

			private bool firstUpdate;

			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			public Body()
				: base()
			{
			}
		}

		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		protected override void OnModifyOffset()
		{
		}

		public Amplifier()
			: base()
		{
		}
	}
}
