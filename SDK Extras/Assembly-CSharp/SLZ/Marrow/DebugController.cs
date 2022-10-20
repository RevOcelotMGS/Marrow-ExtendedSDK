using SLZ.Marrow.Input;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Marrow
{
	public class DebugController : MarrowBehaviour
	{
		public enum Handedness
		{
			NONE = 0,
			LEFT = 1,
			RIGHT = 2
		}

		public BaseController controller;

		public Handedness handedness;

		public Text deviceInfoText;

		public RectTransform primaryAxisRect;

		public Image primaryAxisImg;

		public Image primaryTouchImg;

		private int _joystickButtonFrame;

		private int _joystickTouchFrame;

		[Header("Trigger")]
		public Slider triggerSlider;

		public Image triggerButtonImg;

		public Image triggerTouchImg;

		private int _triggerTouchFrame;

		private int _triggerButtonFrame;

		[Header("Grip")]
		public Slider gripSlider;

		public Image gripButtonImg;

		[Header("Primary Button")]
		public Image primaryButtonImg;

		public Image primaryButtonTouchImg;

		private int _primaryButtonFrame;

		private int _primaryTouchFrame;

		[Header("Secondary Button")]
		public Image secondaryButtonImg;

		public Image secondaryButtonTouchImg;

		private int _secondaryButtonFrame;

		private int _secondaryTouchFrame;

		[Header("THUMBSTICK")]
		public RectTransform thumbstickAxisRect;

		public Image thumbstickAxisImg;

		private int _thumbstickButtonFrame;

		[Header("PRIMARY INTERACTION")]
		public Slider pInteractionSlider;

		public Image pInteractionButtonImg;

		private int _pInteractionButtonFrame;

		[Header("SECONDARY INTERACTION")]
		public Slider sInteractionSlider;

		public Image sInteractionButtonImg;

		private int _sInteractionButtonFrame;

		[Header("B BUTTON")]
		public Image bButtonImg;

		private int _bButtonFrame;

		[Header("A BUTTON")]
		public Image aButtonImg;

		private int _aButtonFrame;

		[Header("MENU BUTTON")]
		public Image menuButtonImg;

		private int _menuButtonFrame;

		[Header("SECONDARY MENU BUTTON")]
		public Image sMenuButtonImg;

		private int _sMenuButtonFrame;

		[Header("MENU TAP")]
		public Image menuTapButtonImg;

		private int _menuTapButtonFrame;

		[Header("GRIP FORCE")]
		public Slider gripForceSlider;

		[Header("GRABBED STATE")]
		public Image grabbedStateButtonImg;

		private int _grabbedStateButtonFrame;

		[Header("IS GRABBED")]
		public Image isGrabbedButtonImg;

		private int _isGrabbedButtonFrame;

		[Header("RELEASED STATE")]
		public Image releaseStateButtonImg;

		private int _releaseStateButtonFrame;

		[Header("IS RELEASED")]
		public Image isReleasedButtonImg;

		private int _isReleasedButtonFrame;

		[Header("HAS BEEN GRABBED")]
		public Image hasBeenGrabbedButtonImg;

		private int _hasBeenGrabbedButtonFrame;

		[Header("THUMB TOUCH")]
		public Image thumbTouchButtonImg;

		private int _thumbTouchButtonFrame;

		private void UpdateValue(Slider slider, float val)
		{
		}

		private void DeviceInfoToText(Text text, XRController controller)
		{
		}

		private void Vector2DToHandle(RectTransform handle, Vector2 vec2)
		{
		}

		private void BoolToImgColor(Image img, bool isPressed, bool isDown, bool isUp, int frameCount)
		{
		}

		private void Update()
		{
		}

		public DebugController()
			: base()
		{
		}
	}
}
