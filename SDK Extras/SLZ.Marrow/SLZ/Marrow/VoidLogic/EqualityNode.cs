using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Equality")]
	public class EqualityNode : BaseNode
	{
		[SerializeField]
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.")]
		private float _tolerance;

		[SerializeField]
		[Tooltip("Whether to check inputs against a predefined power value")]
		private bool _checkPowerValue;

		[Tooltip("A predefined power value to check for equality against")]
		[SerializeField]
		private float _powerValue;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		protected override float CalculateValue()
		{
			return default(float);
		}

		public override void AppendNodeInfo(StringBuilder sb)
		{
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public EqualityNode()
			: base()
		{
		}
	}
}
