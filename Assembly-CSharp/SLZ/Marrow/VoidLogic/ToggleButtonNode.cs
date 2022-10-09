using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Toggle Button")]
	public class ToggleButtonNode : ButtonNode
	{
		private float _multiplier;

		protected override void Update()
		{
		}

		protected override float CalculateValue()
		{
			return default(float);
		}

		public ToggleButtonNode()
			: base()
		{
		}
	}
}
