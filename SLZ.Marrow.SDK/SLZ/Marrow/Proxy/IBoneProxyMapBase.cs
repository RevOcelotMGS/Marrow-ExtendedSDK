using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public interface IBoneProxyMapBase<out ProxyType, out RealType> where ProxyType : IBoneProxyBase<Object> where RealType : Object
	{
		ProxyType Proxy { get; }

		RealType Real { get; }

		bool Mapped { get; }

		void FindAndSetProxy();

		void MapProxyProperties();

		void MapMethods();

		void Map(bool generateReal);

		void AfterMap(bool generatedReal);

		void GenerateReal();

		void BeforeGenerateReal();

		void AfterGenerateReal();

		void CacheReal();
	}
}
