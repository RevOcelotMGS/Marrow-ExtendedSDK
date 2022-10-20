using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ
{
	public class ScreenOptions : MonoBehaviour
	{
		protected delegate void CallbackBool(bool isClicked);

		protected delegate void CallbackFloat(float amount);

		protected enum GUIType
		{
			BUTTON = 0,
			LINE = 1,
			LABEL = 2,
			BOX = 3,
			SLIDER = 4
		}

		protected struct GUIItem
		{
			public GUIType type;

			public string label;

			public float value;

			public float start;

			public float stop;

			public CallbackBool callbackBool;

			public CallbackFloat callbackFloat;

			public GUIItem(GUIType t, float v, float st, float sp, CallbackFloat c = default(CallbackFloat))
			{
				this.callbackFloat = default(CallbackFloat);
				this.callbackBool = default(CallbackBool);
				this.stop = default(float);
				this.start = default(float);
				this.value = default(float);
				this.label = default(string);
				this.type = default(GUIType);
			}

			public GUIItem(GUIType t, string l, float v, float st, float sp, CallbackFloat c = default(CallbackFloat))
			{
				this.callbackFloat = default(CallbackFloat);
				this.callbackBool = default(CallbackBool);
				this.stop = default(float);
				this.start = default(float);
				this.value = default(float);
				this.label = default(string);
				this.type = default(GUIType);
			}

			public GUIItem(GUIType t, string l)
			{
				this.callbackFloat = default(CallbackFloat);
				this.callbackBool = default(CallbackBool);
				this.stop = default(float);
				this.start = default(float);
				this.value = default(float);
				this.label = default(string);
				this.type = default(GUIType);
			}

			public GUIItem(GUIType t, string l, CallbackBool c = default(CallbackBool))
			{
				this.callbackFloat = default(CallbackFloat);
				this.callbackBool = default(CallbackBool);
				this.stop = default(float);
				this.start = default(float);
				this.value = default(float);
				this.label = default(string);
				this.type = default(GUIType);
			}

			public GUIItem(GUIType t, string l, CallbackFloat c = default(CallbackFloat))
			{
				this.callbackFloat = default(CallbackFloat);
				this.callbackBool = default(CallbackBool);
				this.stop = default(float);
				this.start = default(float);
				this.value = default(float);
				this.label = default(string);
				this.type = default(GUIType);
			}
		}

		private float guiMargin;

		private float guiButtonWidth;

		private float guiButtonHeight;

		private float guiLabelHeight;

		private float guiLabelSmallHeight;

		private float guiSliderHeight;

		private float guiInputWidth;

		private float startY;

		private float startX;

		private Texture2D lineTexture;

		private List<GUIItem> guiItems;

		private void SetupTexture()
		{
		}

		protected void StartGUI()
		{
		}

		protected void EndGUI()
		{
		}

		protected void GUIButton(string label, CallbackBool callback)
		{
		}

		protected void GUIButton(string label)
		{
		}

		protected void GUILine()
		{
		}

		protected void GUILabel(string label)
		{
		}

		protected void GUISlider(float value, float start, float stop, CallbackFloat callback)
		{
		}

		protected void GUISlider(string label, float value, float start, float stop, CallbackFloat callback)
		{
		}

		public ScreenOptions()
			: base()
		{
		}
	}
}
