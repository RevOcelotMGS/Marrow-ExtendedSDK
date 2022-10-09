namespace Oculus.Platform.Models
{
	public class Error
	{
		public readonly int Code;

		public readonly int HttpCode;

		public readonly string Message;

		public Error(int code, string message, int httpCode)
			: base()
		{
		}
	}
}
