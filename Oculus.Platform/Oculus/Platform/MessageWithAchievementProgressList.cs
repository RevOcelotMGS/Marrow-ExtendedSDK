using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAchievementProgressList : Message<AchievementProgressList>
	{
		public MessageWithAchievementProgressList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		protected override AchievementProgressList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
