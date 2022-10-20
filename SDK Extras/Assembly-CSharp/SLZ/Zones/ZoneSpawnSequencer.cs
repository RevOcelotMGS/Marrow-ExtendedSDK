using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneSpawnSequencer : ZoneItem
	{
		[Tooltip("Frequency between nodes of sequencer in seconds")]
		public float frequency;

		public bool randomSequence;

		[Tooltip("Max amount that can be spawned")]
		public float maxConcurrentSpawns;

		public ZoneSpawner[] spawners;

		private List<int> _sequenceIndexBuffer;

		private int[] _randomSequenceIndices;

		private Coroutine _sequenceCoroutine;

		private int _currentSequenceItem;

		private bool _hasStarted;

		private void Awake()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		private IEnumerator CoPlaySequencer(GameObject playerObject)
		{
			return null;
		}

		public ZoneSpawnSequencer()
			: base()
		{
		}
	}
}
