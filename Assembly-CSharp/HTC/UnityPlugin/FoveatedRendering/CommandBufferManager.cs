using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace HTC.UnityPlugin.FoveatedRendering
{
	public class CommandBufferManager
	{
		public delegate void CommandBufferEvent(CommandBuffer cmd);

		private class CommandBufferObject
		{
			private string name;

			private CameraEvent cameraEvent;

			private CommandBuffer buffer;

			public CommandBufferObject(string bufName, CameraEvent camEvnt, params CommandBufferEvent[] commands)
				: base()
			{
			}

			public void Enable(Camera cam)
			{
			}

			public void Disable(Camera cam)
			{
			}
		}

		private List<CommandBufferObject> commandBufList;

		public void AppendCommands(string bufName, CameraEvent camEvnt, params CommandBufferEvent[] commands)
		{
			commands = default(CommandBufferEvent[]);
		}

		public void ClearCommands()
		{
		}

		public void EnableCommands(Camera cam)
		{
		}

		public void DisableCommands(Camera cam)
		{
		}

		public CommandBufferManager()
			: base()
		{
		}
	}
}
