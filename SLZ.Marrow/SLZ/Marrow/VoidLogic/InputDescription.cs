using System.Runtime.CompilerServices;

namespace SLZ.Marrow.VoidLogic
{
	public struct InputDescription
	{
		public string Name
		{
			[IsReadOnly]
			get;
			set; }

		public int Offset
		{
			[IsReadOnly]
			get;
			set; }

		public int Width
		{
			[IsReadOnly]
			get;
			set; }
	}
}
