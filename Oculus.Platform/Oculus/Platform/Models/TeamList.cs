using System;

namespace Oculus.Platform.Models
{
	public class TeamList : DeserializableList<Team>
	{
		public TeamList(IntPtr a)
			: base()
		{
		}
	}
}
