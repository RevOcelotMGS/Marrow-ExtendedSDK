using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Forklift
{
	public struct FetchError
	{
		public Exception Exception { get; }

		public int ErrorCode { get; }

		public string ErrorDescription { get; }

		public int Index { get; }

		public FetchError(Exception exception, int index = -1)
		{
			this.Index = default(int);
			this.ErrorDescription = default(string);
			this.ErrorCode = default(int);
			this.Exception = default(Exception);
		}

		public FetchError(int errorCode, string errorDescription, int index = -1)
		{
			this.Index = default(int);
			this.ErrorDescription = default(string);
			this.ErrorCode = default(int);
			this.Exception = default(Exception);
		}
	}
}
