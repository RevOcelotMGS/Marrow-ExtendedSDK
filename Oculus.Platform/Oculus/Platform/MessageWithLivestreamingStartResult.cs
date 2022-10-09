using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLivestreamingStartResult : Message<LivestreamingStartResult>
	{
		public MessageWithLivestreamingStartResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LivestreamingStartResult GetLivestreamingStartResult()
		{
			return null;
		}

		protected override LivestreamingStartResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
