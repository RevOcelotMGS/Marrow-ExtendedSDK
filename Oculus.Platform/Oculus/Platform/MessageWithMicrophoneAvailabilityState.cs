using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithMicrophoneAvailabilityState : Message<MicrophoneAvailabilityState>
	{
		public MessageWithMicrophoneAvailabilityState(IntPtr c_message)
			: base(c_message)
		{
		}

		public override MicrophoneAvailabilityState GetMicrophoneAvailabilityState()
		{
			return null;
		}

		protected override MicrophoneAvailabilityState GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
