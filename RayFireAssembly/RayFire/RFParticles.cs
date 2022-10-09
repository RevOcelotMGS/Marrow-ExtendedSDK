using System;
using System.Collections.Generic;
using UnityEngine;

namespace RayFire
{
	[Serializable]
	public class RFParticles
	{
		public enum RFParticleCollisionMatType
		{
			ByPhysicalMaterial = 0,
			ByProperties = 1
		}

		public enum BurstType
		{
			None = 0,
			TotalAmount = 1,
			PerOneUnitSize = 2,
			FragmentAmount = 3
		}

		public static ParticleSystem.MinMaxCurve constantCurve;

		private static string debrisStr;

		private static string dustStr;

		public static void SetParticleComponents(RayfireRigid scr)
		{
		}

		public static void SetParticleComponents(RayfireRigidRoot scr)
		{
		}

		public static void InitDemolitionParticles(RayfireRigid source)
		{
		}

		public static void CreateDemolitionDebris(RayfireRigid source)
		{
		}

		public static void CreateDemolitionDust(RayfireRigid source)
		{
		}

		public static void InitActivationParticlesRigid(RayfireRigid rigid)
		{
		}

		public static void InitActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
		{
		}

		public static void CreateDebrisRigid(RayfireDebris target)
		{
		}

		public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
		{
		}

		public static void CreateDustRigid(RayfireDust target)
		{
		}

		public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
		{
		}

		public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
		{
			return null;
		}

		public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
		{
			return null;
		}

		private static ParticleSystem CreateParticleSystem(Transform tm)
		{
			return null;
		}

		public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
		{
		}

		public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
		{
		}

		private static void DetachParticles(RayfireRigid source)
		{
		}

		public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
		{
		}

		public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
		{
		}

		public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
		{
		}

		public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
		{
		}

		public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
		{
		}

		public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
		{
		}

		public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
		{
		}

		public static int GetEmissionMatIndex(Renderer renderer, Material mat)
		{
			return default(int);
		}

		public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
		{
		}

		public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
		{
		}

		public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
		{
		}

		public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
		{
		}

		public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
		{
		}

		public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
		{
		}

		public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
		{
		}

		public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
		{
		}

		public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
		{
		}

		public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
		{
		}

		public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
		{
		}

		public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
		{
		}

		public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
		{
		}

		public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
		{
			return default(int);
		}

		public static bool AmountCheck(RayfireRigid source, int pType)
		{
			return default(bool);
		}

		public RFParticles()
			: base()
		{
		}
	}
}
