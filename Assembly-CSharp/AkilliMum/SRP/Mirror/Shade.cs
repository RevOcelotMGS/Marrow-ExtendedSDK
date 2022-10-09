using System;
using UnityEngine;

namespace AkilliMum.SRP.Mirror
{
	[Serializable]
	public class Shade
	{
		public GameObject ObjectToShade;

		public Material MaterialToChange;

		public Shade()
			: base()
		{
		}
	}
}
