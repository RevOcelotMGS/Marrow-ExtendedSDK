using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Endpoints/VoidLogic Material Switcher")]
	public class MaterialSwitcher : MonoBehaviour, InputDescribable
	{
		[Tooltip("Previous node in the chain")]
		[SerializeField]
		private BaseNode _previousNode;

		private float _priorValue;

		[SerializeField]
		private Renderer[] _renderers;

		[SerializeField]
		private int[] _materialIndex;

		[SerializeField]
		private Material _offMat;

		[SerializeField]
		private Material _onMat;

		[SerializeField]
		private float lowThreshold;

		[SerializeField]
		private float highThreshold;

		private bool _isHigh;

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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateMats(Material mat)
		{
		}

		public void AppendEndpointInfo(StringBuilder sb)
		{
		}

		IReadOnlyList<InputDescription> InputDescribable.DescribeInputs()
		{
			return null;
		}

		public MaterialSwitcher()
			: base()
		{
		}
	}
}
