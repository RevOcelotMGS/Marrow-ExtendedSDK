using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithInstalledApplicationList : Message<InstalledApplicationList>
	{
		public MessageWithInstalledApplicationList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override InstalledApplicationList GetInstalledApplicationList()
		{
			return null;
		}

		protected override InstalledApplicationList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
