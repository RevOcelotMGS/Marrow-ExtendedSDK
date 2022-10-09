using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RayFire
{
	[AddComponentMenu("RayFire/Rayfire Blade")]
	[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-blade-component/")]
	public class RayfireBlade : MonoBehaviour
	{
		public enum CutType
		{
			Enter = 0,
			Exit = 1,
			EnterExit = 2
		}

		public enum ActionType
		{
			Slice = 0,
			Demolish = 1
		}

		public ActionType actionType;

		public CutType onTrigger;

		public PlaneType sliceType;

		public float force;

		public bool affectInactive;

		public float damage;

		public bool skin;

		public float cooldown;

		public int mask;

		public string tagFilter;

		public List<GameObject> targets;

		public RayfireRigid rigid;

		public Transform transForm;

		public Vector3[] enterPlane;

		public Vector3[] exitPlane;

		public Collider colLider;

		public Vector3[] slicePlanes;

		public bool coolDownState;

		private RFSliceData sliceData;

		private Vector3 posEnter;

		private Vector3 posExit;

		public RFSliceEvent sliceEvent;

		public bool HasTargets
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
		{
		}

		private void DefineComponents()
		{
		}

		private void OnTriggerEnter(Collider col)
		{
		}

		private void OnTriggerExit(Collider col)
		{
		}

		private void TriggerEnter(Collider col)
		{
		}

		private void TriggerExit(Collider col)
		{
		}

		private void Demolish(GameObject targetObject)
		{
		}

		private IEnumerator CooldownCor()
		{
			return null;
		}

		private void SetCooldown(bool state)
		{
		}

		private bool FilterCheck(GameObject targetObject)
		{
			return default(bool);
		}

		public void SliceTarget()
		{
		}

		private void Slice(GameObject targetObject, Vector3[] slicePlane)
		{
		}

		private bool ApplyDamage(RayfireRigid scr, float damageValue)
		{
			return default(bool);
		}

		private Vector3[] GetSlicePlane()
		{
			return null;
		}

		private RFSliceData GetSliceData()
		{
			return null;
		}

		private bool LayerCheck(int layerId)
		{
			return default(bool);
		}

		public RayfireBlade()
			: base()
		{
		}
	}
}
