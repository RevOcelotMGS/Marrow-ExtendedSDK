using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLivestreamingVideoStats : Message<LivestreamingVideoStats>
	{
		public MessageWithLivestreamingVideoStats(IntPtr c_message)
			: base(c_message)
		{
		}

		public override LivestreamingVideoStats GetLivestreamingVideoStats()
		{
			return null;
		}

		protected override LivestreamingVideoStats GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
