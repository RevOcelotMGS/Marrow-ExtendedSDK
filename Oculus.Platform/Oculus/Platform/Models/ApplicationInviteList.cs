using System;

namespace Oculus.Platform.Models
{
	public class ApplicationInviteList : DeserializableList<ApplicationInvite>
	{
		public ApplicationInviteList(IntPtr a)
			: base()
		{
		}
	}
}
