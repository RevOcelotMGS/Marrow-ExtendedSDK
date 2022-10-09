using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Technie.VirtualConsole
{
	public class VrConsole : DebugPanel
	{
		private struct LogMessage
		{
			public string text;

			public string stackTrace;

			public LogType type;

			public int sequenceNumber;

			public LogMessage(string t, string trace, LogType type, int seqNum)
			{
				this.sequenceNumber = default(int);
				this.type = default(LogType);
				this.stackTrace = default(string);
				this.text = default(string);
			}
		}

		private struct LogLine
		{
			public string text;

			public Color colour;

			public LogLine(string s, Color c)
			{
				this.colour = default(Color);
				this.text = default(string);
			}

			public string AsRichText()
			{
				return null;
			}

			private static string ToHex(float val)
			{
				return null;
			}
		}

		private static readonly Dictionary<LogType, Color> logTypeColors;

		public Text consoleArea;

		public Button infoToggleButton;

		public Button warningToggleButton;

		public Button errorToggleButton;

		public Text infoButtonText;

		public Text warningButtonText;

		public Text errorButtonText;

		private object mutex;

		private List<LogMessage> infoMessages;

		private List<LogMessage> warningMessages;

		private List<LogMessage> errorMessages;

		private int numInfos;

		private int numWarnings;

		private int numErrors;

		private int nextSequenceNumber;

		private bool hasMessagesChanged;

		private bool showInfo;

		private bool showWarnings;

		private bool showErrors;

		private int maxLines;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

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

		private void HandleLog(string text, string stackTrace, LogType type)
		{
		}

		private void UpdateLogVisual()
		{
		}

		private bool TryGenerateConsoleText(List<LogLine> lines, Text targetTextArea, int numLines, [Out] string newText)
		{
			return default(bool);
		}

		private List<LogMessage> FindList(LogType type)
		{
			return null;
		}

		private void IncLogCount(LogType type)
		{
		}

		private int SequenceComparator(LogMessage lhs, LogMessage rhs)
		{
			return default(int);
		}

		private bool ParseTrace(string traceLine, [Out] string namespaceName, [Out] string className, [Out] string methodName, [Out] string fileName, [Out] int lineNumber)
		{
			return default(bool);
		}

		public void ClearLog()
		{
		}

		public void ToggleInfo()
		{
		}

		public void ToggleWarnings()
		{
		}

		public void ToggleErrors()
		{
		}

		private void UpdateButtonColours()
		{
		}

		private static void SetColour(Button button, Color col)
		{
		}

		private static void SetText(Text text, int count)
		{
		}

		public VrConsole()
			: base()
		{
		}
	}
}
