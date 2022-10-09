using UnityEngine;
using UnityEngine.UI;

namespace AkilliMum.SRP.Mirror
{
	public class MainGui : ExecuteOnMainThread
	{
		public Light Light;

		public Material Day;

		public Material Night;

		private bool _day;

		public Text ShaderName;

		public GameObject NormalFloor;

		public GameObject MirrorFloor;

		public GameObject MirrorBlurFloor;

		public GameObject MirrorBlurTexFloor;

		public GameObject MirrorRefFloor;

		public GameObject MirrorRefTexFloor;

		public GameObject MirrorTexFloorSurf;

		public GameObject MirrorBlurTexFloorSurf;

		public GameObject MirrorRefTexFloorSurf;

		public GameObject MirrorAlphaTexFloorSurf;

		public GameObject MirrorTransparent;

		public GameObject MirrorAlphaReflect;

		public GameObject Refraction;

		public GameObject Blur;

		public GameObject Mosaic;

		public GameObject PostEffect;

		public GameObject Portal;

		public GameObject Ghost;

		public GameObject Car;

		public GameObject Heli;

		public void Start()
		{
		}

		public void Off()
		{
		}

		public void ActivateShadows()
		{
		}

		public void ActivateDefault()
		{
		}

		public void SwitchSpinning()
		{
		}

		public void SwitchDayNight()
		{
		}

		public void ActivateMirror()
		{
		}

		public void ActivateRefraction()
		{
		}

		public void ActivateBlur()
		{
		}

		public void ActivateDistortion()
		{
		}

		public void ActivateMosaic()
		{
		}

		public void ActivatePostEffect()
		{
		}

		public void ActivatePortal()
		{
		}

		public void ActivateGhost()
		{
		}

		public void LoadShaderScene()
		{
		}

		public void LoadEffectsScene()
		{
		}

		public MainGui()
			: base()
		{
		}
	}
}
