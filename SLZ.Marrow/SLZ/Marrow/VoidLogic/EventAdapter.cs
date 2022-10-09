using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Endpoints/VoidLogic Event Adapter")]
	public sealed class EventAdapter : MonoBehaviour, InputDescribable
	{
		[Serializable]
		public sealed class NodeOutputValueCurrentAndPrior : UnityEvent<float, float>
		{
			public NodeOutputValueCurrentAndPrior()
				: base()
			{
			}
		}

		[SerializeField]
		[Tooltip("Previous node in the chain")]
		private BaseNode _previousNode;

		[SerializeField]
		private float lowThreshold;

		[SerializeField]
		private float highThreshold;

		[Tooltip("When the power value changes")]
		[Header("Events")]
		public NodeOutputValueCurrentAndPrior NodeOutputValueUpdated;

		[Tooltip("When the power value rises above the high threshold")]
		public UnityEvent NodeOutputRose;

		[Tooltip("When the power value holds above the high threshold")]
		public UnityEvent NodeOutputHeld;

		[Tooltip("When the power value lowers beneath the low threshold")]
		public UnityEvent NodeOutputFell;

		[Tooltip("When the power value rises above the high threshold (for the first time only)")]
		public UnityEvent NodeOutputRoseOneShot;

		private float _priorValue;

		private bool _isHigh;

		private bool _hasBeenHigh;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public BaseNode PreviousNode
		{
			get
			{
				return null;
			}
		}

		public float Value
		{
			get
			{
				return default(float);
			}
		}

		public float PriorValue
		{
			get
			{
				return default(float);
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void LogOutputValueUpdated(float currentValue, float priorValue)
		{
		}

		public void AppendEndpointInfo(StringBuilder sb)
		{
		}

		IReadOnlyList<InputDescription> InputDescribable.DescribeInputs()
		{
			return null;
		}

		public EventAdapter()
			: base()
		{
		}
	}
}
