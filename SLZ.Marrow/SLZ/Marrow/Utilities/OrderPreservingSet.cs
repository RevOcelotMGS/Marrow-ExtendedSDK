using System.Collections;
using System.Collections.Generic;

namespace SLZ.Marrow.Utilities
{
	public class OrderPreservingSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		private readonly IDictionary<T, LinkedListNode<T>> _dictionary;

		private readonly LinkedList<T> _linkedList;

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
		}

		public OrderPreservingSet(IEqualityComparer<T> comparer)
			: this()
		{
		}

		public OrderPreservingSet()
			: base()
		{
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

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
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
	}
}
