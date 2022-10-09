using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		public float magnitude;

		private Recoil recoil;

		private void Start()
		{
		}

		private void OnGUI()
		{
		}

		public RecoilTest()
			: base()
		{
		}
	}
}
