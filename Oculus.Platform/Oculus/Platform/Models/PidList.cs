using System;

namespace Oculus.Platform.Models
{
	public class PidList : DeserializableList<Pid>
	{
		public PidList(IntPtr a)
			: base()
		{
		}
	}
}
