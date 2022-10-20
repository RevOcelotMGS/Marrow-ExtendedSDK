using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Forklift
{
	public struct Result<TOk, TErr>
	{
		public TOk Ok { get; }

		public bool IsOk { get; }

		public TErr Err { get; }

		public bool IsErr
		{
			get
			{
				return default(bool);
			}
		}

		public Result(TOk ok)
		{
			this.Err = default(TErr);
			this.IsOk = default(bool);
			this.Ok = default(TOk);
		}

		public Result(TErr err)
		{
			this.Err = default(TErr);
			this.IsOk = default(bool);
			this.Ok = default(TOk);
		}
	}
}
