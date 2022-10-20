using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Latch")]
	public class LaatschNode : BaseNode
	{
		[SerializeField]
		private float highThreshold;

		private bool _hasBeenHigh;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		protected override float CalculateValue()
		{
			return default(float);
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public LaatschNode()
			: base()
		{
		}
	}
}
