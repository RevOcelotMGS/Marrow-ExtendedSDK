using System.ComponentModel;

namespace Oculus.Platform
{
	public enum KeyValuePairType
	{
		[Description("STRING")]
		String = 0,
		[Description("INTEGER")]
		Int = 1,
		[Description("DOUBLE")]
		Double = 2,
		[Description("UNKNOWN")]
		Unknown = 3
	}
}
