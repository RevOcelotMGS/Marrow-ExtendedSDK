using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLivestreamingStatus : Message<LivestreamingStatus>
	{
		public MessageWithLivestreamingStatus(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LivestreamingStatus GetLivestreamingStatus()
		{
			return null;
		}

		protected override LivestreamingStatus GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
