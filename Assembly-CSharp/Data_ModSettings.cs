using System;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;

[Serializable]
public struct Data_ModSettings : IJSONPackable
{
	public int maxConnections;

	public int maxPerHost;

	public int timeout;

	public static Data_ModSettings Default
	{
		get
		{
			return default(Data_ModSettings);
		}
	}

	public void Pack(ObjectStore store, JObject json)
	{
	}

	public void Unpack(ObjectStore store, ObjectId objectId)
	{
	}
}
