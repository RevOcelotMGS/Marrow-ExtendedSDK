using UnityEngine;

public static class TransformDeepChildExtension
{
	public delegate bool Filter(GameObject go);

	public static Transform FindDeepChild(this Transform aParent, Filter callback)
	{
		return null;
	}

	public static Transform FindDeepChild(this Transform aParent, string aName)
	{
		return null;
	}
}
