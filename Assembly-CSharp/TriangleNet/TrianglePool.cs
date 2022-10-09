using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TriangleNet.Topology;

namespace TriangleNet
{
	public class TrianglePool : ICollection<Triangle>, IEnumerable<Triangle>, IEnumerable
	{
		private class Enumerator : IEnumerator<Triangle>, IEnumerator, IDisposable
		{
			private int count;

			private Triangle[][] pool;

			private Triangle current;

			private int index;

			private int offset;

			public Triangle Current
			{
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			public Enumerator(TrianglePool pool)
				: base()
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Reset()
			{
			}
		}

		private const int BLOCKSIZE = 1024;

		private int size;

		private int count;

		private Triangle[][] pool;

		private Stack<Triangle> stack;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public Triangle Get()
		{
			return null;
		}

		public void Release(Triangle triangle)
		{
		}

		public TrianglePool Restart()
		{
			return null;
		}

		internal IEnumerable<Triangle> Sample(int k, Random random)
		{
			return null;
		}

		private void Cleanup(Triangle triangle)
		{
		}

		public void Add(Triangle item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(Triangle item)
		{
			return default(bool);
		}

		public void CopyTo(Triangle[] array, int index)
		{
		}

		public bool Remove(Triangle item)
		{
			return default(bool);
		}

		public IEnumerator<Triangle> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public TrianglePool()
			: base()
		{
		}
	}
}
