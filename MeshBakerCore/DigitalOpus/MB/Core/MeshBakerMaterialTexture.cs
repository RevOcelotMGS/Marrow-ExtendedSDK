using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public class MeshBakerMaterialTexture
	{
		private Texture2D _t;

		public float texelDensity;

		internal static bool readyToBuildAtlases;

		private DRect encapsulatingSamplingRect;

		public Texture2D t
		{
			set
			{
			}
		}

		public DRect matTilingRect { get; private set; }

		public int isImportedAsNormalMap { get; private set; }

		public bool isNull
		{
			get
			{
				return default(bool);
			}
		}

		public int width
		{
			get
			{
				return default(int);
			}
		}

		public int height
		{
			get
			{
				return default(int);
			}
		}

		public MeshBakerMaterialTexture(Texture tx, Vector2 matTilingOffset, Vector2 matTilingScale, float texelDens, int isImportedAsNormalMap)
			: base()
		{
		}

		public DRect GetEncapsulatingSamplingRect()
		{
			return default(DRect);
		}

		public void SetEncapsulatingSamplingRect(MB_TexSet ts, DRect r)
		{
		}

		public Texture2D GetTexture2D()
		{
			return null;
		}

		public string GetTexName()
		{
			return null;
		}

		public bool AreTexturesEqual(MeshBakerMaterialTexture b)
		{
			return default(bool);
		}
	}
}
