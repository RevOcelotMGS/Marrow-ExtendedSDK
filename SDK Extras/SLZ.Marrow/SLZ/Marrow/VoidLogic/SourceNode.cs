using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Source")]
	public class SourceNode : BaseNode
	{
		[SerializeField]
		[Tooltip("Basic additive power (added to sum of previous inputs or 0)")]
		private float _baseValue;

		[SerializeField]
		[Tooltip("Whether to remap the sum of inputs according to the remap curve")]
		private bool _enableRemap;

		[Tooltip("Output response curve (applied to the sum of previous inputs or 0)")]
		[SerializeField]
		private AnimationCurve _remapCurve;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public float BaseValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override float CalculateValue()
		{
			return default(float);
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public SourceNode()
			: base()
		{
		}
	}
}
