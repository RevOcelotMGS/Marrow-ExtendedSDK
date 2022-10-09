using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public abstract class BaseNode : MonoBehaviour, InputDescribable
	{
		[SerializeField]
		[Tooltip("Previous node(s) in the chain")]
		protected List<BaseNode> _previous;

		protected float _cachedValue;

		public List<BaseNode> PreviousNodes
		{
			get
			{
				return null;
			}
		}

		protected bool IsCachedInternal { get; private set; }

		public bool IsCached
		{
			get
			{
				return default(bool);
			}
		}

		public float OutputValue
		{
			get
			{
				return default(float);
			}
		}

		public void Uncache()
		{
		}

		public void ConnectPrevious(BaseNode node)
		{
		}

		public void DisconnectPrevious(BaseNode node)
		{
		}

		public abstract IReadOnlyList<InputDescription> DescribeInputs();

		public virtual void AppendNodeInfo(StringBuilder sb)
		{
		}

		protected abstract float CalculateValue();

		public BaseNode()
			: base()
		{
		}
	}
}
