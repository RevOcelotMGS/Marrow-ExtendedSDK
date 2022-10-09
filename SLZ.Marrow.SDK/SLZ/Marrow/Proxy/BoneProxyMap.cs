using System;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public abstract class BoneProxyMap<ProxyType, RealScriptType> : MonoBehaviour, IBoneProxyMap<ProxyType, RealScriptType>, IBoneProxyMapBase<ProxyType, RealScriptType> where ProxyType : BoneProxy where RealScriptType : MonoBehaviour
	{
		[SerializeField]
		protected ProxyType _proxy;

		[SerializeField]
		protected RealScriptType _realScript;

		[SerializeField]
		protected bool _mapped;

		public ProxyType Proxy
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public RealScriptType Real
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool Mapped
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public void Awake()
		{
		}

		public void FindAndSetProxy()
		{
		}

		public void MapProxyProperties()
		{
		}

		protected abstract void MapProperties();

		public abstract void MapMethods();

		public void Map(bool generateReal = false)
		{
		}

		public virtual void AfterMap(bool generatedReal)
		{
		}

		public virtual void GenerateReal()
		{
		}

		public virtual void BeforeGenerateReal()
		{
		}

		public virtual void AfterGenerateReal()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public void CacheReal()
		{
		}

		public BoneProxyMap()
			: base()
		{
		}
	}
}
