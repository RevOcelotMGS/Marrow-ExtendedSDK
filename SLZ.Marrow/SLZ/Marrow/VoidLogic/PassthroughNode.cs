using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Passthrough")]
	public class PassthroughNode : BaseNode
	{
		[SerializeField]
		private bool _cutoff;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public bool Cutoff
		{
			get
			{
				return default(bool);
			}
		}

		protected override float CalculateValue()
		{
			return default(float);
		}

		public void Toggle()
		{
		}

		public void TurnOn()
		{
		}

		public void TurnOff()
		{
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public PassthroughNode()
			: base()
		{
		}
	}
}
