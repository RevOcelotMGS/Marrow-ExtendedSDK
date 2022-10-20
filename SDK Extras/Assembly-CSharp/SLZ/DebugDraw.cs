using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ
{
	public class DebugDraw : MonoBehaviour
	{
		public class DebugText
		{
			private List<TextMesh> texts;

			private int textIndex;

			private TextMesh GetText()
			{
				return null;
			}

			public void Draw(string text, Vector3 position, Color color, int size = 36)
			{
			}

			public void Clear()
			{
			}

			public DebugText()
				: base()
			{
			}
		}

		private DebugText debugText;

		public Material lineMat;

		public bool isEnabled;

		public static DebugDraw instance;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void DrawText(string text, Vector3 position, Color color, int size = 36)
		{
		}

		public static void DrawLine(Vector3 start, Vector3 end, Color color, float time = 0f)
		{
		}

		public static void DrawCircle(Vector3 position, Vector3 normal, float radius, Color color, int segments = 16, float time = 0f)
		{
		}

		public static void DrawCircle(Vector3 position, Color color = default(Color), float time = 0f)
		{
		}

		public static void DrawTransform(Transform transform, float time = 0f)
		{
		}

		public static void DrawTransform(SimpleTransform st, float time = 0f)
		{
		}

		public static void DrawTransform(Vector3 position, Quaternion rotation, float time = 0f)
		{
		}

		public static void DrawLog(string text, Vector3 position, float time = 1f, float scale = 1f)
		{
		}

		private void Update()
		{
		}

		private IEnumerator CoEndOfFrame()
		{
			return null;
		}

		public DebugDraw()
			: base()
		{
		}
	}
}
