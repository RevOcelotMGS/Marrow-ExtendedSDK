using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;

namespace SLZ.Marrow.Forklift.Model
{
	[Serializable]
	public class ModRepository : IJSONPackable
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public List<ModListing> Mods { get; set; }

		public void Pack(ObjectStore store, JObject json)
		{
		}

		public void Unpack(ObjectStore store, ObjectId objectId)
		{
		}

		public ModRepository()
			: base()
		{
		}
	}
}
