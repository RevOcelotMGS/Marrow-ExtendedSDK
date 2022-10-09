using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Achievements
	{
		public static Request<AchievementUpdate> AddCount(string name, ulong count)
		{
			return null;
		}

		public static Request<AchievementUpdate> AddFields(string name, string fields)
		{
			return null;
		}

		public static Request<AchievementDefinitionList> GetAllDefinitions()
		{
			return null;
		}

		public static Request<AchievementProgressList> GetAllProgress()
		{
			return null;
		}

		public static Request<AchievementDefinitionList> GetDefinitionsByName(string[] names)
		{
			return null;
		}

		public static Request<AchievementProgressList> GetProgressByName(string[] names)
		{
			return null;
		}

		public static Request<AchievementUpdate> Unlock(string name)
		{
			return null;
		}

		public static Request<AchievementDefinitionList> GetNextAchievementDefinitionListPage(AchievementDefinitionList list)
		{
			return null;
		}

		public static Request<AchievementProgressList> GetNextAchievementProgressListPage(AchievementProgressList list)
		{
			return null;
		}
	}
}
