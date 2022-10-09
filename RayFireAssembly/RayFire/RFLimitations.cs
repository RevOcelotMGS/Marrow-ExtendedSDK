using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFLimitations
	{
		public bool byCollision;

		public float solidity;

		public string tag;

		public int depth;

		public float time;

		public float size;

		public bool visible;

		public bool sliceByBlade;

		[NonSerialized]
		public List<Vector3> slicePlanes;

		[NonSerialized]
		public ContactPoint contactPoint;

		[NonSerialized]
		public Vector3 contactVector3;

		[NonSerialized]
		public Vector3 contactNormal;

		[NonSerialized]
		public bool demolitionShould;

		[NonSerialized]
		public bool demolished;

		[NonSerialized]
		public float birthTime;

		[NonSerialized]
		public float bboxSize;

		[NonSerialized]
		public int currentDepth;

		[NonSerialized]
		public bool demolishableCorState;

		[NonSerialized]
		public float sliceForce;

		[NonSerialized]
		public bool affectInactive;

		[NonSerialized]
		public RayfireRigid ancestor;

		[NonSerialized]
		public List<RayfireRigid> descendants;

		[HideInInspector]
		public Bounds bound;

		private static string rootStr;

		public static string rigidStr;

		public void CopyFrom(RFLimitations limitations)
		{
		}

		public void Reset()
		{
		}

		public IEnumerator DemolishableCor(RayfireRigid scr)
		{
			return null;
		}

		public static void Checks(RayfireRigid scr)
		{
		}

		public static void SetBound(RayfireRigid scr)
		{
		}

		public static void SetAncestor(RayfireRigid scr)
		{
		}

		public static void SetDescendants(RayfireRigid scr)
		{
		}

		public static void CreateRoot(RayfireRigid rfScr)
		{
		}

		public RFLimitations()
			: base()
		{
		}
	}
}
