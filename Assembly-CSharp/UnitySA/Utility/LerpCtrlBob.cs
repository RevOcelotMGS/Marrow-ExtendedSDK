using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnitySA.Utility
{
	[Serializable]
	public class LerpCtrlBob
	{
		public float BobDuration;

		public float BobAmount;

		private float m_Offset;

		public float Offset()
		{
			return default(float);
		}

		public IEnumerator DoBobCycle()
		{
			return null;
		}

		public LerpCtrlBob()
			: base()
		{
		}
	}
}
