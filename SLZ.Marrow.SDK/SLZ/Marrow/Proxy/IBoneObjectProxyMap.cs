using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public interface IBoneObjectProxyMap<out ProxyType, out RealType> : IBoneProxyMapBase<ProxyType, RealType> where ProxyType : IBoneObjectProxy where RealType : ScriptableObject
	{
	}
}
