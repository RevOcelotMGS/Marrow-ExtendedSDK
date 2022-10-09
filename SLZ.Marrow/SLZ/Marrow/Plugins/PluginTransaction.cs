using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SLZ.Marrow.Plugins
{
	internal sealed class PluginTransaction : IDisposable
	{
		internal static ThreadLocal<PluginTransaction> _tl_CurrentTransaction;

		private bool _disposedValue;

		[TupleElementNames(new string[] { "type", "attribute" })]
		private List<ValueTuple<Type, MarrowPluginAttribute>> PendingPlugins;

		public static PluginTransaction OpenTransaction()
		{
			return null;
		}

		private void Dispose(bool disposing)
		{
		}

		~PluginTransaction()
		{
		}

		void IDisposable.Dispose()
		{
		}

		public void AddPlugin([TupleElementNames(new string[] { "type", "attribute" })] ValueTuple<Type, MarrowPluginAttribute> type)
		{
		}

		public bool ContainsPluginType(Type pluginType)
		{
			return default(bool);
		}

		public PluginTransaction()
			: base()
		{
		}
	}
}
