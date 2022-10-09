public static class ExtensionsEnum
{
	public static T Next<T>(this T src) where T : struct
	{
		return (T)default(T);
	}

	public static T Previous<T>(this T src) where T : struct
	{
		return (T)default(T);
	}
}
