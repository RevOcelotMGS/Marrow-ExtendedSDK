using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PathCreation.Examples
{
	[ExecuteInEditMode]
	public abstract class PathSceneTool : MonoBehaviour
	{
		public PathCreator pathCreator;

		public bool autoUpdate;

		private VertexPath storedPath;

		public VertexPath StoredPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected VertexPath path
		{
			get
			{
				return null;
			}
		}

		public void TriggerUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected abstract void PathUpdated();

		public PathSceneTool()
			: base()
		{
		}

		public event Action onDestroyed;
	}
}
