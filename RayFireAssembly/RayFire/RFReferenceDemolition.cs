using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFReferenceDemolition
	{
		public enum ActionType
		{
			Instantiate = 0,
			SetActive = 1
		}

		public GameObject reference;

		public List<GameObject> randomList;

		public ActionType action;

		public bool addRigid;

		public bool inheritScale;

		public bool inheritMaterials;

		public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
		{
		}

		public GameObject GetReference()
		{
			return null;
		}

		public static bool DemolishReference(RayfireRigid scr)
		{
			return default(bool);
		}

		private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
		{
			return null;
		}

		private static void InheritMaterials(RayfireRigid scr, GameObject instGo)
		{
		}

		public RFReferenceDemolition()
			: base()
		{
		}
	}
}
