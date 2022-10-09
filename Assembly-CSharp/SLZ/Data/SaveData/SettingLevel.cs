using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.Data.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SettingLevel : sbyte
	{
		Disabled = -1,
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}
}
