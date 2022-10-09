using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Plug : MonoBehaviour
	{
		private static ComponentCache<Plug> _cache;

		public InteractableHost host;

		public float effectiveRadius;

		protected AssetPoolee _poolee;

		public static ComponentCache<Plug> Cache
		{
			get
			{
				return null;
			}
		}

		private void Reset()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void OnPlugHoverBegin(Socket socket)
		{
		}

		public virtual void OnPlugHoverEnd(Socket socket)
		{
		}

		public virtual void OnPlugHoverUpdate(Socket socket)
		{
		}

		public Plug()
			: base()
		{
		}
	}
}
