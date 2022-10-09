using UnityEngine;

namespace AkilliMum.SRP.Mirror
{
	public static class Extensions
	{
		public static void CopyTo<T>(this Component comp, T target) where T : Component, new()
		{
		}

		public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		public static void SimpleCopy(object source, object target)
		{
		}
	}
}
