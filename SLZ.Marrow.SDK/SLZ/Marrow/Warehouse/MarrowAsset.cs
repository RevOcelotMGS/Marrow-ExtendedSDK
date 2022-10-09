using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class MarrowAsset
	{
		[FormerlySerializedAs("m_AssetGUID")]
		[SerializeField]
		private string _assetGUID;

		private AsyncOperationHandle _operationHandle;

		protected Type _assetType;

		public string AssetGUID
		{
			get
			{
				return null;
			}
		}

		public AsyncOperationHandle OperationHandle
		{
			get
			{
				return default(AsyncOperationHandle);
			}
		}

		public virtual UnityEngine.Object Asset
		{
			get
			{
				return null;
			}
		}

		protected bool IsLoading
		{
			get
			{
				return default(bool);
			}
		}

		protected bool IsDone
		{
			get
			{
				return default(bool);
			}
		}

		public virtual Type AssetType
		{
			get
			{
				return null;
			}
		}

		public virtual UniTask<UnityEngine.Object> LoadTask
		{
			get
			{
				return default(UniTask<UnityEngine.Object>);
			}
			protected set
			{
			}
		}

		public MarrowAsset()
			: base()
		{
		}

		public MarrowAsset(string guid)
			: this()
		{
		}

		protected virtual AsyncOperationHandle<TObject> LoadAssetAsyncInternal<TObject>()
		{
			return default(AsyncOperationHandle<TObject>);
		}

		protected virtual AsyncOperationHandle<SceneInstance> LoadSceneAsyncInternal(LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		protected virtual bool ReleaseAsset()
		{
			return default(bool);
		}

		public UniTask<TObject> LoadAssetAsync<TObject>() where TObject : UnityEngine.Object
		{
			return default(UniTask<TObject>);
		}

		public void LoadAsset<TObject>(Action<TObject> loadCallback) where TObject : UnityEngine.Object
		{
		}

		public UniTask<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default(UniTask<SceneInstance>);
		}

		public bool UnloadAsset(bool forced = false)
		{
			return default(bool);
		}

		public bool Equals(MarrowAsset other)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool operator ==(MarrowAsset left, MarrowAsset right)
		{
			return default(bool);
		}

		public static bool operator !=(MarrowAsset left, MarrowAsset right)
		{
			return default(bool);
		}
	}
}
