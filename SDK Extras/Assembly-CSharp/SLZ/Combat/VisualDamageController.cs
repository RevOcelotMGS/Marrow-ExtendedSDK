using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Combat
{
	public class VisualDamageController : MonoBehaviour
	{
		[NonSerialized]
		private const int MAX_HITS = 32;

		[NonSerialized]
		private int Count;

		[NonSerialized]
		private List<Matrix4x4> HitPoint;

		[NonSerialized]
		private Matrix4x4[] HitPos;

		[NonSerialized]
		private const int MAX_HITS_CUT = 8;

		[NonSerialized]
		private int Count_CUT;

		[NonSerialized]
		private List<Matrix4x4> CutPoint;

		[NonSerialized]
		private Matrix4x4[] CutPos;

		[Tooltip("Renderers to set hit variables for")]
		public Renderer[] Renderers;

		public float meshScaleFactor;

		public float hitScaleFactor;

		private int NumberOfHits;

		private int NumberOfCuts;

		private int NumberOfHitsID;

		private int EllipsoidPosArrayID;

		private int ElipsoidMatricesID;

		private int NumberOfElipsoidsID;

		public bool isLODVisible()
		{
			return default(bool);
		}

		public void AddToHitArray(Matrix4x4 Matrix)
		{
		}

		public void AddToCutArray(Matrix4x4 Matrix)
		{
		}

		public void ResetHits()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void InitializeBlock()
		{
		}

		public void UpdateArray()
		{
		}

		public void collectSkins()
		{
		}

		private IEnumerator BleedOverTimer()
		{
			return null;
		}

		public VisualDamageController()
			: base()
		{
		}
	}
}
