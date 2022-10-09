using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithSystemVoipState : Message<SystemVoipState>
	{
		public MessageWithSystemVoipState(IntPtr c_message)
			: base(c_message)
		{
		}

		public override SystemVoipState GetSystemVoipState()
		{
			return null;
		}

		protected override SystemVoipState GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
