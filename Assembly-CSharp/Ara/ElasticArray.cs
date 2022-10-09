using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ara
{
	public class ElasticArray<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private T[] data;

		private int count;

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

		public T this[int index]
		{
			get
			{
				return (T)default(T);
			}
			set
			{
			}
		}

		public T[] Data
		{
			get
			{
				return null;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return default(bool);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return default(bool);
		}

		public int IndexOf(T item)
		{
			return default(int);
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void SetCount(int count)
		{
		}

		public void EnsureCapacity(int capacity)
		{
		}

		public void Reverse()
		{
		}

		public ElasticArray()
			: base()
		{
		}
	}
}
