using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public abstract class BoneProxy : MonoBehaviour, IBoneProxy, IBoneProxyBase<MonoBehaviour>, ISerializationCallbackReceiver
	{
		[HideInInspector]
		[SerializeField]
		private MonoBehaviour _serializableProxyMap;

		private IBoneProxyMap<BoneProxy, MonoBehaviour> _proxyMap;

		[SerializeField]
		[HideInInspector]
		private bool _forceOverrideProperties;

		private ProxyPropertyMapper _propertyMapper;

		public MonoBehaviour SerializableProxyMap
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IBoneProxyMap<BoneProxy, MonoBehaviour> ProxyMap
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

		public virtual void Awake()
		{
		}

		public virtual void Start()
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

		[ContextMenu("Override Properties now")]
		public void OverridePropertiesNow()
		{
		}

		public BoneProxy()
			: base()
		{
		}
	}
}
