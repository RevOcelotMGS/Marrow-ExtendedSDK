using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SocketVirtualController : MonoBehaviour
	{
		public enum TwistAlingment
		{
			OMNIDIRECTIONAL = 0,
			UNIDIRECTIONAL = 1,
			BIDIRECTIONAL = 2,
			QUADDIRECTIONAL = 4
		}

		public enum PositionalAlignment
		{
			FIXED = 0,
			LINE = 1,
			PLANE = 2
		}

		private static ComponentCache<SocketVirtualController> _cache;

		public PlugVirtualController.FormFactor formFactor;

		public TwistAlingment twistAlingment;

		public PositionalAlignment positionalAlignment;

		public Transform alignTransform;

		public Transform insertTransform;

		public static ComponentCache<SocketVirtualController> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnAttach()
		{
		}

		public void OnDettach()
		{
		}

		public SocketVirtualController()
			: base()
		{
		}
	}
}
