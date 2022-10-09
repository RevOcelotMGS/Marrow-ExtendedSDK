using System;
using UnityEngine;

namespace SLZ
{
	[Serializable]
	public class VirtualControllerSettings
	{
		[Tooltip("Primary to Secondary swing weight (Blends into per-hand swing weight)")]
		[Range(0f, 1f)]
		public float lookRotationWeight;

		[Tooltip("Per-hand blend twist rotation")]
		[Range(0f, 1f)]
		public float handTwistWeight;

		[Tooltip("Per-hand blend swing rotation")]
		[Range(0f, 1f)]
		public float handSwingWeight;

		[Range(0f, 1f)]
		[Tooltip("Per-hand blend position")]
		public float positionWeight;

		[Tooltip("Joint swing limits")]
		[Range(0f, 90f)]
		public float jointSwingLimit;

		[Tooltip("Joint twist limits")]
		[Range(0f, 90f)]
		public float jointTwistLimit;

		[Tooltip("Swap slip rotation to primary grip")]
		public bool autoTargetUpdatePrimary;

		[Tooltip("Dynamic weights based on hand to hand distance")]
		public bool dynamicHandDistanceWeights;

		public VirtualControllerSettings()
			: base()
		{
		}
	}
}
