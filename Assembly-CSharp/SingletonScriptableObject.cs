using UnityEngine;

public class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
{
	private static T s_Instance;

	public static T Instance
	{
		get
		{
			return null;
		}
	}

	public SingletonScriptableObject()
		: base()
	{
	}
}
