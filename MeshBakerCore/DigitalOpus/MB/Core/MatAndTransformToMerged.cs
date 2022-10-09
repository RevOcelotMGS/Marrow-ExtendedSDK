using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MatAndTransformToMerged
	{
		public Material mat;

		public string objName;

		public DRect obUVRectIfTilingSame { get; private set; }

		public DRect samplingRectMatAndUVTiling { get; private set; }

		public DRect materialTiling { get; private set; }

		public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs)
			: base()
		{
		}

		public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
			: base()
		{
		}

		private void _init(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public string GetMaterialName()
		{
			return null;
		}

		public void AssignInitialValuesForMaterialTilingAndSamplingRectMatAndUVTiling(bool allTexturesUseSameMatTiling, DRect matTiling)
		{
		}
	}
}
