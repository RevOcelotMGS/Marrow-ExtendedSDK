using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class ComponentCache<T> : IEnumerable<T>, IEnumerable where T : MonoBehaviour
	{
		private Dictionary<GameObject, List<T>> m_Cache;

		public T ForceGet(GameObject go)
		{
			return null;
		}

		public T Get(GameObject go)
		{
			return null;
		}

		public bool TryGet(GameObject go, [Out] T component)
		{
			return default(bool);
		}

		public bool TryGetAll(GameObject go, [Out] ReadOnlyCollection<T> components)
		{
			return default(bool);
		}

		public void Remove(GameObject go, T component)
		{
		}

		public void Add(GameObject go, T component)
		{
		}

		public void Clear()
		{
		}

		public int Count()
		{
			return default(int);
		}

		public bool Contains(GameObject go)
		{
			return default(bool);
		}

		private IEnumerable<T> Components()
		{
			return null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public ComponentCache()
			: base()
		{
		}
	}
}
