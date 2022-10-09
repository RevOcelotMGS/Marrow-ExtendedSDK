using UnityEngine;

namespace Technie.VirtualConsole
{
	public class UiLaser : MonoBehaviour
	{
		[ReadOnly]
		public GameObject targetHand;

		private WandInputModule inputModule;

		private GameObject cylinder;

		private VrDebugDisplay[] displays;

		private float lastDistance;

		private void Start()
		{
		}

		public void CreateBeam(Material material)
		{
		}

		public void OnHandDetected(int index, GameObject handObj, WandInputModule wandInputModule)
		{
		}

		private void Update()
		{
		}

		private float CalcOpacity()
		{
			return default(float);
		}

		private float CalcOpacity(VrDebugDisplay display)
		{
			return default(float);
		}

		public bool IsPointingAtPanel()
		{
			return default(bool);
		}

		private bool IsPointingAtPanel(VrDebugDisplay display)
		{
			return default(bool);
		}

		public UiLaser()
			: base()
		{
		}
	}
}
