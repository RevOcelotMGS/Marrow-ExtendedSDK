using SLZ.Marrow.Utilities;
using SLZ.Props.Weapons;

namespace SLZ.Interaction
{
	public class AmmoPlug : AlignPlug
	{
		private static ComponentCache<AmmoPlug> _cache;

		public Magazine magazine;

		public new static ComponentCache<AmmoPlug> Cache
		{
			get
			{
				return null;
			}
		}

		protected override void OnPlugInsertComplete()
		{
		}

		protected override void OnPlugExitComplete()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public AmmoPlug()
			: base()
		{
		}
	}
}
