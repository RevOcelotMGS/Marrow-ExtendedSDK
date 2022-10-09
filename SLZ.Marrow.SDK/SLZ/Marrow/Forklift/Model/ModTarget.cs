using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;

namespace SLZ.Marrow.Forklift.Model
{
	[Serializable]
	public abstract class ModTarget : IJSONPackable
	{
		public string ThumbnailOverride { get; set; }

		public virtual void Pack(ObjectStore store, JObject json)
		{
		}

		public virtual void Unpack(ObjectStore store, ObjectId objectId)
		{
		}

		public static ModTarget Create(Type type)
		{
			return null;
		}

		public ModTarget()
			: base()
		{
		}
	}
}
