using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class ProxyPropertyMapper
	{
		public enum PropertyMode
		{
			PROXY = 0,
			MAP = 1,
			AUTO = 2
		}

		private readonly Dictionary<string, ProxyPropertyBase> dictionary;

		private IBoneProxyBase<Object> boneProxy;

		private bool _active;

		public bool Active
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ProxyPropertyMapper(IBoneProxyBase<Object> boneProxy)
			: base()
		{
		}

		public bool HasProperty(string propertyName)
		{
			return default(bool);
		}

		public bool HasProxyProperty(string key)
		{
			return default(bool);
		}

		public bool HasMappedProperty(string key)
		{
			return default(bool);
		}

		public Dictionary<string, ProxyPropertyBase> GetDictionary()
		{
			return null;
		}

		public void AddProxyProperty<T>(string key, BoneProperty<T> proxyProp)
		{
		}

		public void AddMappedProperty<T>(string key, BoneProperty<T> mappedProp)
		{
		}

		public ProxyProperty<T> GetPropertyFull<T>(string key)
		{
			return null;
		}

		public BonePropertyBase GetPropertyBase(string key, PropertyMode propertyMode = PropertyMode.AUTO)
		{
			return null;
		}

		public T GetProxyProperty<T>(string key)
		{
			return (T)default(T);
		}

		public T GetMappedProperty<T>(string key)
		{
			return (T)default(T);
		}

		public T GetProperty<T>(string key, PropertyMode propertyMode = PropertyMode.AUTO)
		{
			return (T)default(T);
		}

		public void SetProxyProperty<T>(string key, T value)
		{
		}

		public void SetMappedProperty<T>(string key, T value)
		{
		}

		public void SetProperty<T>(string key, T value, PropertyMode propertyMode = PropertyMode.AUTO)
		{
		}

		public bool ValidMap()
		{
			return default(bool);
		}

		public void ClearMapped()
		{
		}

		public void OverrideProperties()
		{
		}
	}
}
