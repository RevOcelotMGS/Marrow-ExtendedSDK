using System;

namespace Oculus.Platform.Models
{
	public class Team
	{
		public readonly UserList AssignedUsers;

		public readonly int MaxUsers;

		public readonly int MinUsers;

		public readonly string Name;

		public Team(IntPtr o)
			: base()
		{
		}
	}
}
