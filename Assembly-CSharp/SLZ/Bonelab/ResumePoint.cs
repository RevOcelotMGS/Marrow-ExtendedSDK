using System;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[Serializable]
	public struct ResumePoint
	{
		[Tooltip("Spawn point location")]
		public Transform spawnLocation;

		[Tooltip("Spawn point location for item held in left hand when saving partial progress")]
		public Transform leftHandItem;

		[Tooltip("Spawn point location for item held in right hand when saving partial progress")]
		public Transform rightHandItem;

		[Header("Spawners deactive all previous spawners")]
		[Tooltip("Additional Spawners to be disabled on progression")]
		public ZoneSpawner[] spawners;

		[Tooltip("Game Objects to be disabled on this progression point")]
		public GameObject[] disableObjects;

		[Tooltip("Game Objects to be enabled on this progression point")]
		public GameObject[] enableObjects;

		[Tooltip("Callbacks to invoke when the resume point is reached")]
		public UnityEvent OnReachedResumePoint;
	}
}
