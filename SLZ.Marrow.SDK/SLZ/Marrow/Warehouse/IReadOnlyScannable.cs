namespace SLZ.Marrow.Warehouse
{
	public interface IReadOnlyScannable
	{
		Barcode Barcode { get; }

		string Title { get; }

		string Description { get; }
	}
}
