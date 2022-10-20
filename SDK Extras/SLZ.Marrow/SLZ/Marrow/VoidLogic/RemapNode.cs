using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Remap")]
	public class RemapNode : BaseNode
	{
		[Tooltip("Output response curve (applied to sum of input 1 and above, then multiplied by input 0)")]
		[SerializeField]
		private AnimationCurve _curve;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		protected override float CalculateValue()
		{
			return default(float);
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public RemapNode()
			: base()
		{
		}
	}
}
