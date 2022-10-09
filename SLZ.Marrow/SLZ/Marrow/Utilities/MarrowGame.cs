using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Input;
using SLZ.Marrow.Input.Oculus;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public static class MarrowGame
	{
		public static MarrowPlayerLoop playerLoop;

		public static XRApi xr;

		public static AssetWarehouse assetWarehouse;

		private static Action _onReady;

		public static bool IsInitialized { get; private set; }

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void RuntimeInitializeAfterAssembliesLoaded()
		{
		}

		public static void RegisterOnReadyAction(Action action)
		{
		}

		public static UniTask Initialize()
		{
			return default(UniTask);
		}

		private static UniTask TryInitializeXRApi()
		{
			return default(UniTask);
		}

		private static void OnApplicationQuit()
		{
		}
	}
}
