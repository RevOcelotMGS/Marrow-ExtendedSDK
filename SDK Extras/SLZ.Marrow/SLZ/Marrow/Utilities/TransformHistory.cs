using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class TransformHistory
	{
		public RingBuffer<TemporalTransform> transforms;

		public RingBuffer<TemporalTransform> extrapTransforms;

		public void AddTransform([In] TemporalTransform transform, double toTime)
		{
		}

		private float GetBlendPercentage([In] double fromTime, [In] double toTime, [In] double atTime)
		{
			return default(float);
		}

		public void CopyPoseAtTime(double atTime, [In] Transform transform)
		{
		}

		private bool GetPosesIndexAtTime([In] double atTime, [Out] int atIndex)
		{
			return default(bool);
		}

		public TransformHistory()
			: base()
		{
		}
	}
}
