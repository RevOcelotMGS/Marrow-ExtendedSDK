using UnityEngine;

namespace RootMotion
{
	public static class LayerMaskExtensions
	{
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		public static LayerMask Create(params string[] layerNames)
		{
			layerNames = default(string[]);
			return default(LayerMask);
		}

		public static LayerMask Create(params int[] layerNumbers)
		{
			layerNumbers = default(int[]);
			return default(LayerMask);
		}

		public static LayerMask NamesToMask(params string[] layerNames)
		{
			layerNames = default(string[]);
			return default(LayerMask);
		}

		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			layerNumbers = default(int[]);
			return default(LayerMask);
		}

		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			layerNames = default(string[]);
			return default(LayerMask);
		}

		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			layerNames = default(string[]);
			return default(LayerMask);
		}

		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
}
