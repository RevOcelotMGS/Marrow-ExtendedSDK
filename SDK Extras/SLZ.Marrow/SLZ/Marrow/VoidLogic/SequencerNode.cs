using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Sequencer")]
	public class SequencerNode : BaseNode
	{
		[SerializeField]
		private float _activationThreshold;

		[SerializeField]
		[Tooltip("Timing sequence")]
		private AnimationCurve _sequence;

		[SerializeField]
		[Tooltip("Advance in realtime instead of abiding by timescale")]
		private bool _realtime;

		private bool _isRunning;

		private float _time;

		private float _start;

		private float _reset;

		private float _speed;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		private void Update()
		{
		}

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

		public SequencerNode()
			: base()
		{
		}
	}
}
