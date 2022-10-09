using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		public class OffsetLimits
		{
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Tooltip("The limits")]
			public float minX;

			[Tooltip("The limits")]
			public float maxX;

			[Tooltip("The limits")]
			public float minY;

			[Tooltip("The limits")]
			public float maxY;

			[Tooltip("The limits")]
			public float minZ;

			[Tooltip("The limits")]
			public float maxZ;

			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			public OffsetLimits()
				: base()
			{
			}
		}

		[Tooltip("The master weight")]
		public float weight;

		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		protected float lastTime;

		protected float deltaTime
		{
			get
			{
				return default(float);
			}
		}

		protected abstract void OnModifyOffset();

		protected virtual void Start()
		{
		}

		private IEnumerator Initiate()
		{
			return null;
		}

		private void ModifyOffset()
		{
		}

		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public OffsetModifier()
			: base()
		{
		}
	}
}
