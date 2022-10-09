namespace Oculus.Platform
{
	public class VoipPCMSourceNative : IVoipPCMSource
	{
		private ulong senderID;

		public int GetPCM(float[] dest, int length)
		{
			return default(int);
		}

		public void SetSenderID(ulong senderID)
		{
		}

		public int PeekSizeElements()
		{
			return default(int);
		}

		public void Update()
		{
		}

		public VoipPCMSourceNative()
			: base()
		{
		}
	}
}
