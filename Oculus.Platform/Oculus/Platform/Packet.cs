using System;

namespace Oculus.Platform
{
	public sealed class Packet : IDisposable
	{
		private readonly ulong size;

		private readonly IntPtr packetHandle;

		public ulong SenderID
		{
			get
			{
				return default(ulong);
			}
		}

		public ulong Size
		{
			get
			{
				return default(ulong);
			}
		}

		public SendPolicy Policy
		{
			get
			{
				return default(SendPolicy);
			}
		}

		public Packet(IntPtr packetHandle)
			: base()
		{
		}

		public ulong ReadBytes(byte[] destination)
		{
			return default(ulong);
		}

		~Packet()
		{
		}

		public void Dispose()
		{
		}
	}
}
