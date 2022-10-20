using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public interface IBoneProxyBase<out ProxyType> : ISerializationCallbackReceiver where ProxyType : Object
	{
		ProxyType SerializableProxyMap { get; }

		IBoneProxyMapBase<IBoneProxyBase<Object>, Object> ProxyMapBase { get; }

		bool ForceOverrideProperties { get; set; }

		ProxyPropertyMapper PropertyMapper { get; }

		void Map(bool generateReal);

		void CreateMap();

		void SetupProxyProperties();

		void OverrideProperties();
	}
}
