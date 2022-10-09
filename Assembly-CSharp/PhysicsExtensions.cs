using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class PhysicsExtensions
{
	private class AscendingDistanceComparer : IComparer<RaycastHit>
	{
		public int Compare(RaycastHit h1, RaycastHit h2)
		{
			return default(int);
		}

		public AscendingDistanceComparer()
			: base()
		{
		}
	}

	private static AscendingDistanceComparer ascendDistance;

	public static bool BoxCast(BoxCollider box, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	public static bool BoxCast(BoxCollider box, Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	public static RaycastHit[] BoxCastAll(BoxCollider box, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return null;
	}

	public static int BoxCastNonAlloc(BoxCollider box, Vector3 direction, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(int);
	}

	public static bool CheckBox(BoxCollider box, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	public static Collider[] OverlapBox(BoxCollider box, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return null;
	}

	public static int OverlapBoxNonAlloc(BoxCollider box, Collider[] results, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(int);
	}

	public static void ToWorldSpaceBox(this BoxCollider box, [Out] Vector3 center, [Out] Vector3 halfExtents, [Out] Quaternion orientation)
	{
	}

	public static bool SphereCast(SphereCollider sphere, Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	public static RaycastHit[] SphereCastAll(SphereCollider sphere, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return null;
	}

	public static int SphereCastNonAlloc(SphereCollider sphere, Vector3 direction, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(int);
	}

	public static bool CheckSphere(SphereCollider sphere, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	public static Collider[] OverlapSphere(SphereCollider sphere, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return null;
	}

	public static int OverlapSphereNonAlloc(SphereCollider sphere, Collider[] results, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(int);
	}

	public static void ToWorldSpaceSphere(this SphereCollider sphere, [Out] Vector3 center, [Out] float radius)
	{
	}

	public static bool CapsuleCast(CapsuleCollider capsule, Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	public static RaycastHit[] CapsuleCastAll(CapsuleCollider capsule, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return null;
	}

	public static int CapsuleCastNonAlloc(CapsuleCollider capsule, Vector3 direction, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(int);
	}

	public static bool CheckCapsule(CapsuleCollider capsule, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(bool);
	}

	public static Collider[] OverlapCapsule(CapsuleCollider capsule, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return null;
	}

	public static int OverlapCapsuleNonAlloc(CapsuleCollider capsule, Collider[] results, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return default(int);
	}

	public static void ToWorldSpaceCapsule(this CapsuleCollider capsule, [Out] Vector3 point0, [Out] Vector3 point1, [Out] float radius)
	{
	}

	public static void SortClosestToFurthest(RaycastHit[] hits, int hitCount = -1)
	{
	}

	private static Vector3 AbsVec3(Vector3 v)
	{
		return default(Vector3);
	}

	private static float MaxVec3(Vector3 v)
	{
		return default(float);
	}
}
