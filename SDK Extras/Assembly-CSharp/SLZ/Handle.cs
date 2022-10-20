using UnityEngine;

namespace SLZ
{
	public abstract class Handle<T> : MonoBehaviour where T : MonoBehaviour
	{
		protected T value;

		public Handle()
			: base()
		{
		}
	}
}
