using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Xor")]
	public class XorNode : BaseNode
	{
		private static readonly IReadOnlyList<InputDescription> _inputs;

		protected override float CalculateValue()
		{
			return default(float);
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public XorNode()
			: base()
		{
		}
	}
}
