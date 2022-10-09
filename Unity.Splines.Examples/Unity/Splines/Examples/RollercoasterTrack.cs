using System;
using UnityEngine;
using UnityEngine.Splines;

namespace Unity.Splines.Examples
{
	[Serializable]
	public class RollercoasterTrack : Spline
	{
		private const string k_GeneratedMeshDirectory = "Assets/Generated/Rollercoaster";

		[Range(0.1f, 10f)]
		[SerializeField]
		private float m_TrackWidth;

		[SerializeField]
		private int m_TracksPerMeter;

		[SerializeField]
		private Mesh m_Mesh;

		public Mesh mesh
		{
			get
			{
				return null;
			}
		}

		protected override void OnSplineChanged()
		{
		}

		public void RebuildTracks()
		{
		}

		public RollercoasterTrack()
			: base()
		{
		}
	}
}
