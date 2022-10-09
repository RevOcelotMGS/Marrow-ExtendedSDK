using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	[RequireComponent(typeof(SplineContainer))]
	public class DisplayCurvatureOnSpline : MonoBehaviour
	{
		[Serializable]
		public struct CurvatureConfig
		{
			public bool display;

			public float time;
		}

		public List<CurvatureConfig> m_CurvatureTimes;

		private SplineContainer m_Container;

		public SplineContainer container
		{
			get
			{
				return null;
			}
		}

		public DisplayCurvatureOnSpline()
			: base()
		{
		}
	}
}
