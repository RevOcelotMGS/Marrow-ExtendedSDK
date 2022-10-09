using System;
using System.Collections;
using System.Collections.Generic;

namespace Oculus.Platform.Models
{
	public class DeserializableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		protected List<T> _Data;

		protected string _NextUrl;

		protected string _PreviousUrl;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		bool ICollection<T>.IsReadOnly
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

		[Obsolete("Use IList interface on the DeserializableList object instead.", false)]
		public List<T> Data
		{
			get
			{
				return null;
			}
		}

		public bool HasNextPage
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasPreviousPage
		{
			get
			{
				return default(bool);
			}
		}

		public string NextUrl
		{
			get
			{
				return null;
			}
		}

		public string PreviousUrl
		{
			get
			{
				return null;
			}
		}

		public int IndexOf(T obj)
		{
			return default(int);
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

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public void Insert(int index, T item)
		{
		}

		public bool Remove(T item)
		{
			return default(bool);
		}

		public void RemoveAt(int index)
		{
		}

		private IEnumerator GetEnumerator1()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public DeserializableList()
			: base()
		{
		}
	}
}
