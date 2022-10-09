using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithApplicationVersion : Message<ApplicationVersion>
	{
		public MessageWithApplicationVersion(IntPtr c_message)
			: base(c_message)
		{
		}

		public override ApplicationVersion GetApplicationVersion()
		{
			return null;
		}

		protected override ApplicationVersion GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
