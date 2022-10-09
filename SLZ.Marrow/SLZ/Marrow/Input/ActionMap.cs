using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

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
