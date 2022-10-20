using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class CylinderElectronicGrip : CylinderGrip
	{
		[HideInInspector]
		public ElectricInteractionVolume interactionVolume;

		[Tooltip("Reference to the body grip to sync up")]
		public CylinderElectronicGrip BodyGrip;

		[Tooltip("Reference to the handle grip to sync up")]
		public CylinderElectronicGrip HandleGrip;

		public Transform powerSourceTransform;

		public Transform insertTransform;

		public Transform ejectTransform;

		[Header("COMPATIBLE")]
		[SerializeField]
		private PowerSourceType m_currentType;

		public PowerSourceType CurrentType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public void AnimateInsert(Vector3 localPos)
		{
		}

		private IEnumerator CoAnimateTo(Transform source, SimpleTransform from, SimpleTransform to, float duration = 0.1f)
		{
			return null;
		}

		public void AnimateEject()
		{
		}

		public void SetInsertVolume(ElectricInteractionVolume eVol)
		{
		}

		public CylinderElectronicGrip()
			: base()
		{
		}
	}
}
