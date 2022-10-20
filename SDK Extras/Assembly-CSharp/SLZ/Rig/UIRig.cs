using System.Runtime.CompilerServices;
using SLZ.UI;
using SLZ.UI.Radial;
using UnityEngine;

namespace SLZ.Rig
{
	public class UIRig : MonoBehaviour
	{
		public RigManager manager;

		public PopUpMenuView popUpMenu;

		public UI_HUD uiHud;

		public Transform[] scaleOffset;

		[HideInInspector]
		public float cur_avatarArmScaleMult;

		public Control_Player controlPlayer;

		public Feedback_Audio feedbackAudio;

		public Feedback_Tactile feedbackTactile;

		private float standardArmLength;

		private float uiScale;

		public static UIRig Instance { get; private set; }

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void EarlyUpdate()
		{
		}

		public void UI_AVATARSCALE(float armLength)
		{
		}

		public UIRig()
			: base()
		{
		}
	}
}
