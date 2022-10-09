using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	public static class CrossPlatformInputManager
	{
		public class VirtualAxis
		{
			private float m_Value;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public float GetValue
			{
				get
				{
					return default(float);
				}
			}

			public float GetValueRaw
			{
				get
				{
					return default(float);
				}
			}

			public VirtualAxis(string name)
				: base()
			{
			}

			public VirtualAxis(string name, bool matchToInputSettings)
				: base()
			{
			}

			public void Remove()
			{
			}

			public void Update(float value)
			{
			}
		}

		public class VirtualButton
		{
			private int m_LastPressedFrame;

			private int m_ReleasedFrame;

			private bool m_Pressed;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public bool GetButton
			{
				get
				{
					return default(bool);
				}
			}

			public bool GetButtonDown
			{
				get
				{
					return default(bool);
				}
			}

			public bool GetButtonUp
			{
				get
				{
					return default(bool);
				}
			}

			public VirtualButton(string name)
				: base()
			{
			}

			public VirtualButton(string name, bool matchToInputSettings)
				: base()
			{
			}

			public void Pressed()
			{
			}

			public void Released()
			{
			}

			public void Remove()
			{
			}
		}

		private static VirtualInput virtualInput;

		public static Vector3 mousePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		static CrossPlatformInputManager()
		{
		}

		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		public static void UnRegisterVirtualAxis(string name)
		{
		}

		public static void UnRegisterVirtualButton(string name)
		{
		}

		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		public static float GetAxis(string name)
		{
			return default(float);
		}

		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		public static bool GetButton(string name)
		{
			return default(bool);
		}

		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		public static void SetButtonDown(string name)
		{
		}

		public static void SetButtonUp(string name)
		{
		}

		public static void SetAxisPositive(string name)
		{
		}

		public static void SetAxisNegative(string name)
		{
		}

		public static void SetAxisZero(string name)
		{
		}

		public static void SetAxis(string name, float value)
		{
		}

		public static void SetVirtualMousePositionX(float f)
		{
		}

		public static void SetVirtualMousePositionY(float f)
		{
		}

		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
}
