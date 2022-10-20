using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ
{
	[RequireComponent(typeof(Renderer))]
	[ExecuteInEditMode]
	public class TextureArrayApplicator : MonoBehaviour
	{
		private static ComponentCache<TextureArrayApplicator> _cache;

		private int _texArrayHash;

		private int _texArrayHash2;

		private int _colorHash;

		[SerializeField]
		public Texture2DArray textureArray;

		public int m_selection;

		public int m_2nd_selection;

		public Color m_color;

		[HideInInspector]
		[SerializeField]
		private Renderer matrenderer;

		private MaterialPropertyBlock _propertyBlock;

		public static ComponentCache<TextureArrayApplicator> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		public void SetSelection(int Selection)
		{
		}

		public void SetSelection(int Selection, Color TintColor)
		{
		}

		public void SetSelection(Color TintColor)
		{
		}

		public void SetSelection(int Selection, int Selection2, Color TintColor)
		{
		}

		public void ClearSelection()
		{
		}

		public TextureArrayApplicator()
			: base()
		{
		}
	}
}
