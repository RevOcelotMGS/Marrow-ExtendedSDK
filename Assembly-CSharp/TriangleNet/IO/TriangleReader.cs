using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	public class TriangleReader
	{
		private static NumberFormatInfo nfi;

		private int startIndex;

		public static bool IsNullOrWhiteSpace(string value)
		{
			return default(bool);
		}

		private bool TryReadLine(StreamReader reader, [Out] string[] token)
		{
			return default(bool);
		}

		private void ReadVertex(List<Vertex> data, int index, string[] line, int attributes, int marks)
		{
		}

		public void Read(string filename, [Out] Polygon polygon)
		{
		}

		public void Read(string filename, [Out] Polygon geometry, [Out] List<ITriangle> triangles)
		{
		}

		public IPolygon Read(string filename)
		{
			return null;
		}

		public Polygon ReadNodeFile(string nodefilename)
		{
			return null;
		}

		public Polygon ReadNodeFile(string nodefilename, bool readElements)
		{
			return null;
		}

		public Polygon ReadPolyFile(string polyfilename)
		{
			return null;
		}

		public Polygon ReadPolyFile(string polyfilename, bool readElements)
		{
			return null;
		}

		public Polygon ReadPolyFile(string polyfilename, bool readElements, bool readArea)
		{
			return null;
		}

		public List<ITriangle> ReadEleFile(string elefilename)
		{
			return null;
		}

		private List<ITriangle> ReadEleFile(string elefilename, bool readArea)
		{
			return null;
		}

		private double[] ReadAreaFile(string areafilename, int intriangles)
		{
			return null;
		}

		public List<Edge> ReadEdgeFile(string edgeFile, int invertices)
		{
			return null;
		}

		public TriangleReader()
			: base()
		{
		}
	}
}
