using System;
using System.Text;
using UnityEngine.LowLevel;

namespace SLZ.Marrow.Utilities
{
	public class MarrowPlayerLoop
	{
		private Action _startFrameDelegate;

		private Action _preNewInputUpdateDelegate;

		private Action _postNewInputUpdateDelegate;

		private Action _earlyUpdateDelegate;

		private Action _updateDelegate;

		private Action _preFixedUpdate;

		private Action _postFixedUpdate;

		private Action _endFrameDelegate;

		public void RegisterComponent(MarrowBehaviour gameComponent)
		{
		}

		public void UnregisterComponent(MarrowBehaviour gameComponent)
		{
		}

		public void RegisterLoopAction(UpdateLoopActions loopAction, Action action)
		{
		}

		public void UnregisterLoopAction(UpdateLoopActions loopAction, Action action)
		{
		}

		private void Setup()
		{
		}

		private void AddLoopSystem<CustomSystemT, SubSystemT>(PlayerLoopSystem system, int subSysIdx, PlayerLoopSystem.UpdateFunction Callback, bool isBefore = false)
		{
		}

		private void OnStartFrame()
		{
		}

		private void OnPreNewInputUpdate()
		{
		}

		private void OnPostNewInputUpdate()
		{
		}

		private void OnEarlyUpdate()
		{
		}

		private void OnUpdate()
		{
		}

		private void OnPreFixedUpdate()
		{
		}

		private void OnPostFixedUpdate()
		{
		}

		private void OnEndFrame()
		{
		}

		private void PlayerLoopPrint()
		{
		}

		private void RecursivePlayerLoopPrint(PlayerLoopSystem plSystem, StringBuilder sb, int depth)
		{
		}

		public MarrowPlayerLoop()
			: base()
		{
		}
	}
}
