using System;

namespace RayFire
{
	[Serializable]
	public class RFMeshExport
	{
		public enum MeshExportType
		{
			LastFragments = 0,
			Children = 3
		}

		public MeshExportType source;

		public string suffix;

		public RFMeshExport()
			: base()
		{
		}
	}
}
