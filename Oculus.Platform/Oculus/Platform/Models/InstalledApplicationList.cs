using System;

namespace Oculus.Platform.Models
{
	public class InstalledApplicationList : DeserializableList<InstalledApplication>
	{
		public InstalledApplicationList(IntPtr a)
			: base()
		{
		}
	}
}
