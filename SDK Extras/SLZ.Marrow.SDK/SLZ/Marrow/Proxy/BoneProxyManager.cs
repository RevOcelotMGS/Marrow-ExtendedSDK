using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public class BoneProxyManager : SingletonScriptableObject<BoneProxyManager>
	{
		private string instanceID;

		[SerializeField]
		private TypeTypeDictionary _proxyMapDictionary;

		[SerializeField]
		private List<SerializableType> _proxyTypes;

		[SerializeField]
		private List<SerializableType> _proxyMapTypes;

		private Dictionary<IBoneProxyMapBase<BoneObjectProxy, ScriptableObject>, BoneObjectProxy> _tempSetupBoneObjectMaps;

		[SerializeField]
		private Dictionary<UnityEngine.Object, IBoneProxyBase<UnityEngine.Object>> _realToProxyCache;

		[SerializeField]
		private ObjectObjectDictionary _serializeableRealToProxyCache;

		public TypeTypeDictionary ProxyMapDictionary
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public List<SerializableType> ProxyTypes
		{
			get
			{
				return null;
			}
		}

		public List<SerializableType> ProxyMapTypes
		{
			get
			{
				return null;
			}
		}

		public Dictionary<IBoneProxyMapBase<BoneObjectProxy, ScriptableObject>, BoneObjectProxy> TempSetupBoneObjectMaps
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Dictionary<UnityEngine.Object, IBoneProxyBase<UnityEngine.Object>> RealToProxyCache
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public ObjectObjectDictionary SerializableRealToProxyCache
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public void UpdateCache()
		{
		}

		public IBoneProxyBase<UnityEngine.Object> GetCachedRealToProxy(UnityEngine.Object real)
		{
			return null;
		}

		/*protected override void OnEnable()
		{
		}*/

		[ContextMenu("Reset")]
		private void Reset()
		{
		}

		[ContextMenu("Setup")]
		private void SetupData()
		{
		}

		private IEnumerable<Type> CollectProxyTypes()
		{
			return null;
		}

		private IEnumerable<Type> CollectMapTypes()
		{
			return null;
		}

		public IBoneProxyMap<BoneProxy, MonoBehaviour> CreateBoneProxyMap(BoneProxy proxy)
		{
			return null;
		}

		public IBoneObjectProxyMap<BoneObjectProxy, ScriptableObject> CreateBoneObjectProxyMap(BoneObjectProxy proxy)
		{
			return null;
		}

		public IBoneProxyMap<BoneProxy, MonoBehaviour> CreateBoneProxyMap(GameObject targetGO, Type proxyMapType)
		{
			return null;
		}

		public IBoneObjectProxyMap<BoneObjectProxy, ScriptableObject> CreateBoneObjectProxyMap(BoneObjectProxy proxyObject, Type proxyMapType)
		{
			return null;
		}

		public IBoneProxyMap<BoneProxy, MonoBehaviour> CreateBoneProxyMap<MapType>(GameObject targetGO) where MapType : Component
		{
			return null;
		}

		public BoneProxyManager()
			: base()
		{
		}
	}
}
