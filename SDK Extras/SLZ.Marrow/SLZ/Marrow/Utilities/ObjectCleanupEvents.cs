using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class ObjectCleanupEvents : MonoBehaviour
	{
		private static ComponentCache<ObjectCleanupEvents> _cache;

		public static ComponentCache<ObjectCleanupEvents> Cache
		{
			get
			{
				return null;
			}
		}

		public virtual void Awake()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public virtual void OnCleanup()
		{
		}

		public ObjectCleanupEvents()
			: base()
		{
		}
	}
}
