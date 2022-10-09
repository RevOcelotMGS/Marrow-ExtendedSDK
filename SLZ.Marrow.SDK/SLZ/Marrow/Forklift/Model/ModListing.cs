using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Warehouse;
using SLZ.Serialize;

namespace SLZ.Marrow.Forklift.Model
{
	[Serializable]
	public class ModListing : IJSONPackable, IReadOnlyScannable
	{
		private WeakReference<ModRepository> _repository;

		public Barcode Barcode { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string Author { get; set; }

		public string Version { get; set; }

		public bool Internal { get; set; }

		public List<string> Tags { get; set; }

		public string ThumbnailUrl { get; set; }

		public string ManifestUrl { get; set; }

		public StringModTargetListingDictionary Targets { get; set; }

		public ISet<string> targetNames
		{
			get
			{
				return null;
			}
		}

		public ModRepository Repository
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TListingType GetTargetListing<TListingType>(string targetName) where TListingType : ModTarget
		{
			return null;
		}

		public void Pack(ObjectStore store, JObject json)
		{
		}

		public void Unpack(ObjectStore store, ObjectId objectId)
		{
		}

		public ModListing()
			: base()
		{
		}
	}
}
