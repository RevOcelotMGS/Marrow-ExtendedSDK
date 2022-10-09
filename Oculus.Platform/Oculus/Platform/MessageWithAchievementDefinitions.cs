using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAchievementDefinitions : Message<AchievementDefinitionList>
	{
		public MessageWithAchievementDefinitions(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		protected override AchievementDefinitionList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
