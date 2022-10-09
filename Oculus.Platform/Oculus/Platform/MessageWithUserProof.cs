using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserProof : Message<UserProof>
	{
		public MessageWithUserProof(IntPtr c_message)
			: base(c_message)
		{
		}

		public override UserProof GetUserProof()
		{
			return null;
		}

		protected override UserProof GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
