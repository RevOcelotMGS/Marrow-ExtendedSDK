using System;

namespace Oculus.Platform.Models
{
	public class Challenge
	{
		public readonly ChallengeCreationType CreationType;

		public readonly string Description;

		public readonly DateTime EndDate;

		public readonly ulong ID;

		public readonly UserList InvitedUsersOptional;

		[Obsolete("Deprecated in favor of InvitedUsersOptional")]
		public readonly UserList InvitedUsers;

		public readonly Leaderboard Leaderboard;

		public readonly UserList ParticipantsOptional;

		[Obsolete("Deprecated in favor of ParticipantsOptional")]
		public readonly UserList Participants;

		public readonly DateTime StartDate;

		public readonly string Title;

		public readonly ChallengeVisibility Visibility;

		public Challenge(IntPtr o)
			: base()
		{
		}
	}
}
