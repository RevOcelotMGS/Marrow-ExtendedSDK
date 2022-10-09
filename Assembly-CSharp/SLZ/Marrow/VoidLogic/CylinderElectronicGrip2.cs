using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public class CylinderElectronicGrip2 : CylinderGrip
	{
		public delegate void HandAttached(IGrippable host, CylinderElectronicGrip2 grip);

		[Tooltip("Reference to the body grip to sync up")]
		public CylinderElectronicGrip2 BodyGrip;

		[Tooltip("Reference to the handle grip to sync up")]
		public CylinderElectronicGrip2 HandleGrip;

		public Transform powerSourceTransform;

		public Transform insertTransform;

		public HandAttached handAttached;

		public override void OnAttachedToHand(Hand hand)
		{
		}

		internal void AnimateInsert()
		{
		}

		public CylinderElectronicGrip2()
			: base()
		{
		}
	}
}
