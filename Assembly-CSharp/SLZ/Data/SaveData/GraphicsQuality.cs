using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.Data.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GraphicsQuality : sbyte
	{
		Custom = -1,
		Potato = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Ultra = 4
	}
}
