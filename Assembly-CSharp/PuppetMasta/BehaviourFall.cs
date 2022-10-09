using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

namespace PuppetMasta
{
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourFall")]
	public class BehaviourFall : BehaviourBase
	{
		[LargeHeader("Animation State")]
		[Tooltip("Animation State to crossfade to when this behaviour is activated.")]
		public string stateName;

		[Tooltip("The duration of crossfading to 'State Name'. Value is in seconds.")]
		public float transitionDuration;

		[Tooltip("Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.")]
		public int layer;

		[Tooltip("Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.")]
		public float fixedTime;

		[Tooltip("The layers that will be raycasted against to find colliding objects.")]
		[LargeHeader("Blending")]
		public LayerMask raycastLayers;

		[Tooltip("The parameter in the Animator that blends between catch fall and writhe animations.")]
		public string blendParameter;

		[Tooltip("The height of the pelvis from the ground at which will blend to writhe animation.")]
		public float writheHeight;

		[Tooltip("The vertical velocity of the pelvis at which will blend to writhe animation.")]
		public float writheYVelocity;

		[Tooltip("The speed of blendig between the two falling animations.")]
		public float blendSpeed;

		[Tooltip("The speed of blending in mapping on activation.")]
		public float blendMappingSpeed;

		[Tooltip("If false, this behaviour will never end.")]
		[LargeHeader("Ending")]
		public bool canEnd;

		[Tooltip("The minimum time since this behaviour activated before it can end.")]
		public float minTime;

		[Tooltip("If the velocity of the pelvis falls below this value, can end the behaviour.")]
		public float maxEndVelocity;

		[Tooltip("Event triggered when all end conditions are met.")]
		public PuppetEvent onEnd;

		private float timer;

		private bool endTriggered;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		protected override void OnActivate()
		{
		}

		protected override void OnDeactivate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		private IEnumerator SmoothActivate()
		{
			return null;
		}

		protected override void OnFixedUpdate()
		{
		}

		protected override void OnLateUpdate()
		{
		}

		public override void Resurrect()
		{
		}

		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		private float GetGroundHeight()
		{
			return default(float);
		}

		public BehaviourFall()
			: base()
		{
		}
	}
}
