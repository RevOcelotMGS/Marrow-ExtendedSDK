using UnityEngine;

namespace SLZ.Interaction
{
	public class CylinderFuseGrip : CylinderGrip
	{
		[HideInInspector]
		public FuseInteractionVolume interactionVolume;

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public CylinderFuseGrip()
			: base()
		{
		}
	}
}
