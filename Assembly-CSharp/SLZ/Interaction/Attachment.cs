using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace SLZ.Interaction
{
	public class Attachment : Connector
	{
		private IGrippable host;

		private bool _isAttached;

		private new void Awake()
		{
		}

		protected override void OnConnectorHover()
		{
		}

		private UniTaskVoid AnimateAttach()
		{
			return default(UniTaskVoid);
		}

		public Attachment()
			: base()
		{
		}
	}
}
