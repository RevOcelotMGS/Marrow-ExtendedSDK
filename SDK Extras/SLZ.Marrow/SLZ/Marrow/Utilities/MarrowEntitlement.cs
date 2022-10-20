using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace SLZ.Marrow.Utilities
{
	public static class MarrowEntitlement
	{
		public static UniTask<bool> CheckEntitlementAsync(string appId)
		{
			return default(UniTask<bool>);
		}

		public static void Close()
		{
		}

		private static UniTask<bool> CheckOculusEntitlementAsync(string appId)
		{
			return default(UniTask<bool>);
		}
	}
}
