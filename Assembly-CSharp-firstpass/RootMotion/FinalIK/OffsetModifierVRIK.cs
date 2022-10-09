using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Tooltip("The master weight")]
		public float weight;

		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		private float lastTime;

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

		protected virtual void OnDestroy()
		{
		}

		public OffsetModifierVRIK()
			: base()
		{
		}
	}
}
