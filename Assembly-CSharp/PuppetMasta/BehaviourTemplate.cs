using UnityEngine;

namespace PuppetMasta
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourTemplate")]
	public class BehaviourTemplate : BehaviourBase
	{
		public SubBehaviourCOM centerOfMass;

		public LayerMask groundLayers;

		public PuppetEvent onLoseBalance;

		public float loseBalanceAngle;

		public BehaviourTemplate()
			: base()
		{
		}
	}
}
