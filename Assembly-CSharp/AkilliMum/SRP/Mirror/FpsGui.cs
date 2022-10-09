using UnityEngine;
using UnityEngine.UI;

namespace AkilliMum.SRP.Mirror
{
	public class FpsGui : MonoBehaviour
	{
		public Text Text;

		public float updateInterval;

		private float accum;

		private int frames;

		private float timeleft;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public FpsGui()
			: base()
		{
		}
	}
}
