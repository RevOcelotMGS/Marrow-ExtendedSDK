using System;
using UnityEngine;

namespace RootMotion
{
	public static class BipedNaming
	{
		[Serializable]
		public enum BoneType
		{
			Unassigned = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Leg = 4,
			Tail = 5,
			Eye = 6
		}

		[Serializable]
		public enum BoneSide
		{
			Center = 0,
			Left = 1,
			Right = 2
		}

		public static string[] typeLeft;

		public static string[] typeRight;

		public static string[] typeSpine;

		public static string[] typeHead;

		public static string[] typeArm;

		public static string[] typeLeg;

		public static string[] typeTail;

		public static string[] typeEye;

		public static string[] typeExclude;

		public static string[] typeExcludeSpine;

		public static string[] typeExcludeHead;

		public static string[] typeExcludeArm;

		public static string[] typeExcludeLeg;

		public static string[] typeExcludeTail;

		public static string[] typeExcludeEye;

		public static string[] pelvis;

		public static string[] hand;

		public static string[] foot;

		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			namings = default(string[][]);
			return null;
		}

		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			namings = default(string[][]);
			return null;
		}

		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		private static string firstLetter(string boneName)
		{
			return null;
		}

		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
}
