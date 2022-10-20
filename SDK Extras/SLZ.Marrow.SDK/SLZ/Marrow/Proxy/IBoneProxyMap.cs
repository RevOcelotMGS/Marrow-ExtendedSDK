using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public interface IBoneProxyMap<out ProxyType, out RealType> : IBoneProxyMapBase<ProxyType, RealType> where ProxyType : IBoneProxy where RealType : MonoBehaviour
	{
	}
}
