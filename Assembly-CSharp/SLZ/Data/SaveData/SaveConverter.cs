using System;
using Newtonsoft.Json;

namespace SLZ.Data.SaveData
{
	public class SaveConverter : JsonConverter<Save>
	{
		private readonly SaveFlags _flags;

		public SaveConverter(SaveFlags flags)
			: base()
		{
		}

		public override void WriteJson(JsonWriter writer, Save save, JsonSerializer serializer)
		{
		}

		public override Save ReadJson(JsonReader reader, Type objectType, Save existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
