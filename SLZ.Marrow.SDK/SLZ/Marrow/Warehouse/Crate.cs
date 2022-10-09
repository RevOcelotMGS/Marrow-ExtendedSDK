using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public abstract class Crate : Scannable, ICrate, IJSONPackable
	{
		[SerializeField]
		private Pallet _pallet;

		[SerializeField]
		private List<string> _tags;

		private static Dictionary<Type, string> _crateNames;

		public virtual MarrowAsset MainAsset { get; set; }

		public virtual Type AssetType
		{
			get
			{
				return null;
			}
		}

		public Pallet Pallet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> Tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Dictionary<Type, string> CrateNames
		{
			get
			{
				return null;
			}
		}

		public static string GetCrateName(Type crateType)
		{
			return null;
		}

		public override void GenerateBarcodeInternal(bool forceGeneration = false)
		{
		}

		public virtual UniTask<UnityEngine.Object> LoadAssetAsync()
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public virtual void LoadAsset(Action<UnityEngine.Object> loadCallback)
		{
		}

		public virtual void Pack(ObjectStore store, JObject json)
		{
		}

		public virtual void Unpack(ObjectStore store, ObjectId objectId)
		{
		}

		public static Crate CreateCrate(Type type, Pallet pallet, string title, MarrowAsset marrowAsset, bool generateBarcode = true)
		{
			return null;
		}

		public static T CreateCrateT<T>(Pallet pallet, string title, MarrowAsset marrowAsset, bool generateBarcode = true) where T : Crate
		{
			return null;
		}

		public Crate()
			: base()
		{
		}
	}
}
