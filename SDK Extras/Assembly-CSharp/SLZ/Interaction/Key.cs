using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Key : MonoBehaviour
	{
		private static ComponentCache<Key> _cache;

		[EnumFlags]
		public KeyReciever.Code code;

		public static ComponentCache<Key> Cache
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

		public Key()
			: base()
		{
		}
	}
}
