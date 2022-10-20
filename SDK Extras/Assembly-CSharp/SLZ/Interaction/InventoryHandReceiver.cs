using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class InventoryHandReceiver : MonoBehaviour
	{
		private static ComponentCache<InventoryHandReceiver> _cache;

		public UnityEvent OnHover;

		public UnityEvent OnHoverBegin;

		public UnityEvent OnHoverEnd;

		public UnityEvent OnDrop;

		public UnityEvent OnGrab;

		public static ComponentCache<InventoryHandReceiver> Cache
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

		public virtual void OnHandDrop(IGrippable host)
		{
		}

		public virtual void OnHandGrab(Hand hand)
		{
		}

		public virtual void OnHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnHandHoverEnd(Hand hand)
		{
		}

		public virtual void OnHandHover(Hand hand)
		{
		}

		public virtual float Validate(Hand hand)
		{
			return default(float);
		}

		public InventoryHandReceiver()
			: base()
		{
		}
	}
}
