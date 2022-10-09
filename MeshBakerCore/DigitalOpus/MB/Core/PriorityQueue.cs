using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DigitalOpus.MB.Core
{
	public class PriorityQueue<TPriority, TValue> : ICollection<KeyValuePair<TPriority, TValue>>, IEnumerable<KeyValuePair<TPriority, TValue>>, IEnumerable
	{
		public List<KeyValuePair<TPriority, TValue>> _baseHeap;

		private IComparer<TPriority> _comparer;

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

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

		public PriorityQueue()
			: base()
		{
		}

		public PriorityQueue(int capacity)
			: this()
		{
		}

		public PriorityQueue(int capacity, IComparer<TPriority> comparer)
			: this()
		{
		}

		public PriorityQueue(IComparer<TPriority> comparer)
			: this()
		{
		}

		public PriorityQueue(IEnumerable<KeyValuePair<TPriority, TValue>> data)
			: this()
		{
		}

		public PriorityQueue(IEnumerable<KeyValuePair<TPriority, TValue>> data, IComparer<TPriority> comparer)
			: this()
		{
		}

		public static PriorityQueue<TPriority, TValue> MergeQueues(PriorityQueue<TPriority, TValue> pq1, PriorityQueue<TPriority, TValue> pq2)
		{
			return null;
		}

		public static PriorityQueue<TPriority, TValue> MergeQueues(PriorityQueue<TPriority, TValue> pq1, PriorityQueue<TPriority, TValue> pq2, IComparer<TPriority> comparer)
		{
			return null;
		}

		public void Enqueue(TPriority priority, TValue value)
		{
		}

		public KeyValuePair<TPriority, TValue> Dequeue()
		{
			return default(KeyValuePair<TPriority, TValue>);
		}

		public TValue DequeueValue()
		{
			return (TValue)default(TValue);
		}

		public KeyValuePair<TPriority, TValue> Peek()
		{
			return default(KeyValuePair<TPriority, TValue>);
		}

		public TValue PeekValue()
		{
			return (TValue)default(TValue);
		}

		private void ExchangeElements(int pos1, int pos2)
		{
		}

		private void Insert(TPriority priority, TValue value)
		{
		}

		private int HeapifyFromEndToBeginning(int pos)
		{
			return default(int);
		}

		private void DeleteRoot()
		{
		}

		private void HeapifyFromBeginningToEnd(int pos)
		{
		}

		public void Add(KeyValuePair<TPriority, TValue> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(KeyValuePair<TPriority, TValue> item)
		{
			return default(bool);
		}

		public bool TryFindValue(TPriority item, [Out] TValue foundVersion)
		{
			return default(bool);
		}

		public void CopyTo(KeyValuePair<TPriority, TValue>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<TPriority, TValue> item)
		{
			return default(bool);
		}

		public IEnumerator<KeyValuePair<TPriority, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
