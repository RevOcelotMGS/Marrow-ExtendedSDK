using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public abstract class BoneObjectProxy : ScriptableObject, IBoneObjectProxy, IBoneProxyBase<ScriptableObject>, ISerializationCallbackReceiver
	{
		[SerializeField]
		private ScriptableObject _serializableProxyMap;

		private IBoneObjectProxyMap<BoneObjectProxy, ScriptableObject> _proxyMap;

		[SerializeField]
		private bool _forceOverrideProperties;

		private ProxyPropertyMapper _propertyMapper;

		public ScriptableObject SerializableProxyMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IBoneObjectProxyMap<BoneObjectProxy, ScriptableObject> ProxyMap
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IBoneProxyMapBase<IBoneProxyBase<Object>, Object> ProxyMapBase
		{
			get
			{
				return null;
			}
		}

		public bool ForceOverrideProperties
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ProxyPropertyMapper PropertyMapper
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		public void Map(bool generateReal)
		{
		}

		public void CreateMap()
		{
		}

		public void SetupProxyProperties()
		{
		}

		protected abstract void SetupProperties();

		public void OverrideProperties()
		{
		}

		public T GetPropertyValue<T>(string propertyName)
		{
			return (T)default(T);
		}

		public void SetPropertyValue<T>(string propertyName, T propertyValue)
		{
		}

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}

		[ContextMenu("Map Now")]
		public void DoMapNow()
		{
		}

		[ContextMenu("Map and Generate")]
		public void DoMapGenerate()
		{
		}

		[ContextMenu("Clear Map")]
		public void Clearem()
		{
		}

		[ContextMenu("Nukem")]
		public void Nukem()
		{
		}

		public BoneObjectProxy()
			: base()
		{
		}
	}
}
