using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SLZ.Data.SaveData
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpectatorCameraMode : sbyte
	{
		Passthrough = 0,
		Fisheye = 1,
		Void = 2
	}
}
