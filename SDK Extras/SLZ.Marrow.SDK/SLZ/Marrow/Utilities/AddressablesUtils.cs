using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SLZ.Marrow.Utilities
{
	public class AddressablesUtils
	{
		[Serializable]
		public class AssetReferenceScene : AssetReference
		{
			public AssetReferenceScene(string guid)
				: base()
			{
			}

			public override bool ValidateAsset(UnityEngine.Object obj)
			{
				return default(bool);
			}

			public override bool ValidateAsset(string path)
			{
				return default(bool);
			}
		}

		public AddressablesUtils()
			: base()
		{
		}
	}
}
