using System;

namespace Oculus.Platform
{
	public class MessageWithString : Message<string>
	{
		public MessageWithString(IntPtr c_message)
			: base(c_message)
		{
		}

		public override string GetString()
		{
			return null;
		}

		protected override string GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
