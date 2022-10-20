using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public abstract class CrateT<T> : Crate where T : UnityEngine.Object
	{
		public override Type AssetType
		{
			get
			{
				return null;
			}
		}

		public new UniTask<T> LoadAssetAsync()
		{
			return default(UniTask<T>);
		}

		public void LoadAsset(Action<T> loadCallback)
		{
		}

		public CrateT()
			: base()
		{
		}
	}
}
