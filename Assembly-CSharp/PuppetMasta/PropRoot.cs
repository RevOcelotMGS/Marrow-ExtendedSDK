using UnityEngine;

namespace PuppetMasta
{
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Root")]
	public class PropRoot : MonoBehaviour
	{
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Tooltip("If a prop is connected, what will it's joint be connected to?")]
		public Rigidbody connectTo;

		[Tooltip("Is there a Prop connected to this PropRoot? Simply assign this value to connect, replace or drop props.")]
		public Prop currentProp;

		private Prop lastProp;

		private bool fixedUpdateCalled;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		public void DropImmediate()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void AttachProp(Prop prop)
		{
		}

		public PropRoot()
			: base()
		{
		}
	}
}
