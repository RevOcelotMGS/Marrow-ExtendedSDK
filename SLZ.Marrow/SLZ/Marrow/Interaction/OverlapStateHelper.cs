using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class OverlapStateHelper : MonoBehaviour
	{
		private static ComponentCache<OverlapStateHelper> _cache;

		public static ComponentCache<OverlapStateHelper> Cache
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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		public OverlapStateHelper()
			: base()
		{
		}
	}
}
