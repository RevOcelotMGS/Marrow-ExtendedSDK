using Newtonsoft.Json.Linq;
using SLZ.Serialize;

namespace SLZ.Marrow.Warehouse
{
	public class DataCard : Scannable, IJSONPackable
	{
		public override void GenerateBarcodeInternal(bool forceGeneration = false)
		{
		}

		public void Pack(ObjectStore store, JObject json)
		{
		}

		public void Unpack(ObjectStore store, ObjectId objectId)
		{
		}

		public DataCard()
			: base()
		{
		}
	}
}
