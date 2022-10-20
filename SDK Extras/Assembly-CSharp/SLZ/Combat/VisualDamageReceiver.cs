using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace SLZ.Combat
{
	public class VisualDamageReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		[HideInInspector]
		[SerializeField]
		private Vector3 orgpos;

		[SerializeField]
		[HideInInspector]
		private Quaternion orgrot;

		[HideInInspector]
		[SerializeField]
		private Vector3 orgScale;

		public Transform bone;

		[SerializeField]
		[FormerlySerializedAs("ParentObj")]
		private VisualDamageController visualDamageController;

		[Space(10f)]
		[Header("CutOut area")]
		[Space(5f)]
		[SerializeField]
		public GibletEllipsoid[] gibletEllipsoid;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		private int RandomizeGib()
		{
			return default(int);
		}

		public void GibletEllipsoidGenerate(int GibletNumber)
		{
		}

		public static Vector3 ExtractTranslationFromMatrix(Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		public static Quaternion ExtractRotationFromMatrix(Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		public static Vector3 ExtractScaleFromMatrix(Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		public static void DecomposeMatrix(Matrix4x4 matrix, [Out] Vector3 localPosition, [Out] Quaternion localRotation, [Out] Vector3 localScale)
		{
		}

		public static void SetTransformFromMatrix(Transform transform, Matrix4x4 matrix)
		{
		}

		public VisualDamageReceiver()
			: base()
		{
		}
	}
}
