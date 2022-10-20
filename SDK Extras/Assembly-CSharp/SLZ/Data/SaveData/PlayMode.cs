using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.Data.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PlayMode : sbyte
	{
		VRMODE = 0,
		PCMODE = 1,
		ASYMMODE = 2
	}
}
