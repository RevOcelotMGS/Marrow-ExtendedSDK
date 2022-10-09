using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCalApplicationProposed : Message<CalApplicationProposed>
	{
		public MessageWithCalApplicationProposed(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CalApplicationProposed GetCalApplicationProposed()
		{
			return null;
		}

		protected override CalApplicationProposed GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
