using System;
using UnityEngine;

namespace MK.Glow
{
	[Serializable]
	public sealed class Resources : ScriptableObject
	{
		[SerializeField]
		private Texture2D _lensSurfaceDirtTextureDefault;

		[SerializeField]
		private Texture2D _lensSurfaceDiffractionTextureDefault;

		[SerializeField]
		private Texture2D _lensFlareColorRampDefault;

		[SerializeField]
		private Shader _selectiveRenderShader;

		[SerializeField]
		private Shader _sm20Shader;

		[SerializeField]
		private Shader _sm25Shader;

		[SerializeField]
		private Shader _sm30Shader;

		[SerializeField]
		private Shader _sm35Shader;

		[SerializeField]
		private Shader _sm40Shader;

		[SerializeField]
		private Shader _sm40GeometryShader;

		[SerializeField]
		private ComputeShader _computeShader;

		[SerializeField]
		private ComputeShader _computeShaderGles;

		internal Texture2D lensSurfaceDirtTextureDefault
		{
			get
			{
				return null;
			}
		}

		internal Texture2D lensSurfaceDiffractionTextureDefault
		{
			get
			{
				return null;
			}
		}

		internal Texture2D lensFlareColorRampDefault
		{
			get
			{
				return null;
			}
		}

		internal Shader selectiveRenderShader
		{
			get
			{
				return null;
			}
		}

		internal Shader sm20Shader
		{
			get
			{
				return null;
			}
		}

		internal Shader sm25Shader
		{
			get
			{
				return null;
			}
		}

		internal Shader sm30Shader
		{
			get
			{
				return null;
			}
		}

		internal Shader sm35Shader
		{
			get
			{
				return null;
			}
		}

		internal Shader sm40Shader
		{
			get
			{
				return null;
			}
		}

		internal Shader sm40GeometryShader
		{
			get
			{
				return null;
			}
		}

		internal ComputeShader computeShader
		{
			get
			{
				return null;
			}
		}

		internal static void ResourcesNotAvailableWarning()
		{
		}

		internal static Resources LoadResourcesAsset()
		{
			return null;
		}

		public Resources()
			: base()
		{
		}
	}
}
