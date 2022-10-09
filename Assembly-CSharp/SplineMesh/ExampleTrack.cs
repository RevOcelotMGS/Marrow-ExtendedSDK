using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SplineMesh
{
	[ExecuteInEditMode]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class ExampleTrack : MonoBehaviour
	{
		private GameObject generated;

		private Spline spline;

		private bool toUpdate;

		public List<TrackSegment> segments;

		public bool updateInPlayMode;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public void CreateMeshes()
		{
		}

		public ExampleTrack()
			: base()
		{
		}
	}
}
