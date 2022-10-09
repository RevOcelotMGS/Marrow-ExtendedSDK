using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCalApplicationFinalized : Message<CalApplicationFinalized>
	{
		public MessageWithCalApplicationFinalized(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CalApplicationFinalized GetCalApplicationFinalized()
		{
			return null;
		}

		protected override CalApplicationFinalized GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
