using System;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	[Serializable]
	public abstract class BoneObjectProxyMap<ProxyObjectType, RealObjectType> : ScriptableObject, IBoneObjectProxyMap<ProxyObjectType, RealObjectType>, IBoneProxyMapBase<ProxyObjectType, RealObjectType> where ProxyObjectType : BoneObjectProxy where RealObjectType : ScriptableObject
	{
		[SerializeField]
		protected ProxyObjectType _proxy;

		[SerializeField]
		protected RealObjectType _realObject;

		[SerializeField]
		private bool _mapped;

		public ProxyObjectType Proxy
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public RealObjectType Real
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

		public BoneObjectProxyMap()
			: base()
		{
		}
	}
}
