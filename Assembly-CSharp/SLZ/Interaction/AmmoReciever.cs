using System;
using SLZ.Props.Weapons;
using UnityEngine;

namespace SLZ.Interaction
{
	public class AmmoReciever : InteractionReciever
	{
		[Header("References")]
		public Transform startInsertTarget;

		public Transform endInsertTarget;

		public AudioClip[] insertClips;

		public AudioClip[] ejectClips;

		[HideInInspector]
		public Action<Magazine> OnInserted;

		public override void OnInteractableHostEnter(InteractableHost host)
		{
		}

		public AmmoReciever()
			: base()
		{
		}
	}
}
