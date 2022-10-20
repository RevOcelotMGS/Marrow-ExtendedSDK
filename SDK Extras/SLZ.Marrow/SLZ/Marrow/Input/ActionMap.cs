using Assets.Marrow_ExtendedSDK.StubClasses;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Input
{
	public class ActionMap
	{
		public InputDevice ISDevice { get; protected set; }

		public virtual void OnPreNewInputUpdate()
		{
		}

		public virtual void OnPostNewInputUpdate()
		{
		}

		public ActionMap()
			: base()
		{
		}
	}
}
