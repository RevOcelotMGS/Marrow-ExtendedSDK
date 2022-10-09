using System;

namespace Cpp2IlInjected
{
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
