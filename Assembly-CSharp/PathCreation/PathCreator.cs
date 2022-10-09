using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PathCreation
{
	public class PathCreator : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private PathCreatorData editorData;

		[HideInInspector]
		[SerializeField]
		private bool initialized;

		private GlobalDisplaySettings globalEditorDisplaySettings;

		public bool ignoreGizmos;

		public VertexPath path
		{
			get
			{
				return null;
			}
		}

		public BezierPath bezierPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PathCreatorData EditorData
		{
			get
			{
				return null;
			}
		}

		public void InitializeEditorData(bool in2DMode)
		{
		}

		public void TriggerPathUpdate()
		{
		}

		public PathCreator()
			: base()
		{
		}

		public event Action pathUpdated;
	}
}
