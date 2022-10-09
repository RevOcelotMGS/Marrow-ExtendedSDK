using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.UI;

namespace Technie.VirtualConsole
{
	public class VrDebugStats : DebugPanel
	{
		private class StatPage
		{
			private Dictionary<string, string> stats;

			public StatPage(string cat)
				: base()
			{
			}

			public void SetStat(string name, string value)
			{
			}

			public void GetStats(List<string> keys, List<string> values)
			{
			}
		}

		public Text pageTitle;

		public Text fullPanelText;

		public Text leftCollumnText;

		public Text rightCollumnText;

		private static bool allowLogging;

		private static Dictionary<string, StatPage> pages;

		private static List<string> categories;

		private static bool hasStatsChanged;

		private string currentCategory;

		private bool useTwoCollumns;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public override void OnAttach()
		{
		}

		public override void OnDetach()
		{
		}

		public override void OnResized(VrDebugDisplay.State size)
		{
		}

		private void UpdateStats()
		{
		}

		private bool TryGenerateConsoleText(List<string> lines, Text targetTextArea, int numLines, [Out] string newText)
		{
			return default(bool);
		}

		public void ClearStats()
		{
		}

		public void PrevCategory()
		{
		}

		public void NextCateogry()
		{
		}

		private void ChangeCategory(int direction)
		{
		}

		public static void AllowLogging(bool allow)
		{
		}

		public static void SetStat(string category, string name, bool value)
		{
		}

		public static void SetStat(string category, string name, int value)
		{
		}

		public static void SetStat(string category, string name, string value)
		{
		}

		private static StatPage FindPage(string categoryName)
		{
			return null;
		}

		public VrDebugStats()
			: base()
		{
		}
	}
}
