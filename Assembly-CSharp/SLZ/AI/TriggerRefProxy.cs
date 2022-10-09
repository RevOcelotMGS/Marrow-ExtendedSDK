using System;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.AI
{
	public class TriggerRefProxy : MonoBehaviour
	{
		public enum TriggerType
		{
			Player = 0,
			Proxy = 1,
			Npc = 2
		}

		[Flags]
		public enum NpcType
		{
			FordHair = 1,
			FordShortHair = 2,
			EarlyExit = 4,
			NullBody = 8,
			Fordlet = 0x10,
			Crablet = 0x20,
			OmniProjector = 0x40,
			OmniWrecker = 0x80,
			OmniTurret = 0x100,
			Turret = 0x200,
			NullRat = 0x400,
			Voidman = 0x800
		}

		private static ComponentCache<TriggerRefProxy> _cache;

		private AIBrain _aiManager;

		public AllianceData allianceData;

		public AllianceTable allianceTable;

		public TriggerType triggerType;

		public NpcType npcType;

		public int teamNumber;

		public GameObject root;

		public Rigidbody targetHead;

		public Rigidbody lfHandRb;

		public Rigidbody rtHandRb;

		public Hand lfHand;

		public Hand rtHand;

		public Transform chestTran;

		public Transform feetTran;

		public static ComponentCache<TriggerRefProxy> Cache
		{
			get
			{
				return null;
			}
		}

		public AIBrain aiManager
		{
			get
			{
				return null;
			}
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void OnDestroy()
		{
		}

		public TriggerRefProxy()
			: base()
		{
		}
	}
}
