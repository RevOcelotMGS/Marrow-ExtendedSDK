using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;

namespace SLZ.Marrow.Forklift.Model
{
	[Serializable]
	public class DownloadableModTarget : ModTarget
	{
		public string Url { get; set; }

		public override void Pack(ObjectStore store, JObject json)
		{
		}

		public override void Unpack(ObjectStore store, ObjectId objectId)
		{
		}

		public DownloadableModTarget()
			: base()
		{
		}
	}
}
