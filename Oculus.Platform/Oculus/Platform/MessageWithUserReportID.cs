using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserReportID : Message<UserReportID>
	{
		public MessageWithUserReportID(IntPtr c_message)
			: base(c_message)
		{
		}

		public override UserReportID GetUserReportID()
		{
			return null;
		}

		protected override UserReportID GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
