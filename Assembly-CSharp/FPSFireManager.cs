using System;
using UnityEngine;

public class FPSFireManager : MonoBehaviour
{
	[Serializable]
	public class ImpactInfo
	{
		public MaterialType.MaterialTypeEnum MaterialType;

		public GameObject ImpactEffect;

		public ImpactInfo()
			: base()
		{
		}
	}

	public ImpactInfo[] ImpactElemets;

	[Space]
	public float BulletDistance;

	public GameObject ImpactEffect;

	private void Update()
	{
	}

	private GameObject GetImpactEffect(GameObject impactedGameObject)
	{
		return null;
	}

	public FPSFireManager()
		: base()
	{
	}
}
