using System;
using System.Collections.Generic;
using UnityEngine;

namespace AkilliMum.SRP.Mirror
{
	public class ExecuteOnMainThread : MonoBehaviour
	{
		private List<ThreadAction> _actions;

		public static object Lock;

		protected void Execute(Action action, string groupName = "", float delay = 0f, bool stopOnTimeScale = true)
		{
		}

		protected void CancelExecute(string groupName)
		{
		}

		protected virtual void Update()
		{
		}

		public ExecuteOnMainThread()
			: base()
		{
		}
	}
}
