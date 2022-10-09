using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Utilities
{
	public class RingBuffer<TStruct> where TStruct : struct
	{
		private TStruct[] _buffer;

		private int _size;

		private int _cursor;

		public int Length { get; private set; }

		public RingBuffer(int size)
			: base()
		{
		}

		public void Add([In] TStruct tStruct)
		{
		}

		public TStruct GetReadOnly(int index)
		{
			return (TStruct)default(TStruct);
		}

		public TStruct Get(int index)
		{
			return (TStruct)default(TStruct);
		}

		public void Clear()
		{
		}

		private int Mod(int x, int m)
		{
			return default(int);
		}
	}
}
