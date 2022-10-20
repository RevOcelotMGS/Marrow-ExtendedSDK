using System;
using System.Collections.Generic;

public static class DelegateExtensions
{
	private static readonly List<Exception> _exceptions;

	public static void SafeInvoke(this Delegate del, params object[] args)
	{
		args = default(object[]);
	}
}
