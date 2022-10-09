using System.Collections.Generic;
using SLZ.Props;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ElevatorDoorTrigger : MonoBehaviour
	{
		[SerializeField]
		private bool isExitTrigger;

		[SerializeField]
		private TutorialElevator elevator;

		[SerializeField]
		private List<ObjectDestructable> destObjList;

		private HashSet<GameObject> containedObjHash;

		public void OnDoorClose()
		{
		}

		public void OnTriggerEnter(Collider col)
		{
		}

		public void OnTriggerExit(Collider col)
		{
		}

		public ElevatorDoorTrigger()
			: base()
		{
		}
	}
}
