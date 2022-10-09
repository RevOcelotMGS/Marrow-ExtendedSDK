using System;

namespace Oculus.Platform.Models
{
	public class SdkAccountList : DeserializableList<SdkAccount>
	{
		public SdkAccountList(IntPtr a)
			: base()
		{
		}
	}
}
