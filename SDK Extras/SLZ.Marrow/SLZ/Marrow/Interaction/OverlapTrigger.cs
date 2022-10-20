using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class OverlapTrigger : MonoBehaviour
	{
		private static ComponentCache<OverlapTrigger> _cache;

		[SerializeField]
		private Rigidbody _rigidbody;

		public static ComponentCache<OverlapTrigger> Cache
		{
			get
			{
				return null;
			}
		}

		private static OverlapTriggerPlugin Plugin
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected void OnDisable()
		{
		}

		protected virtual void Reset()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public virtual void OnOverlapEnter(GameObject other)
		{
		}

		public virtual void OnOverlapExit(GameObject other)
		{
		}

		public OverlapTrigger()
			: base()
		{
		}
	}
}
