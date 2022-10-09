using System.Collections.Generic;
using SLZ.Data.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

public class CrateFilters : MonoBehaviour
{
	public class UnlockedNotUnlockableAndNotRedactedFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public UnlockedNotUnlockableAndNotRedactedFilter()
			: base()
		{
		}
	}

	public class UnlockableNotUnlockedAndNotRedactedFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public UnlockableNotUnlockedAndNotRedactedFilter()
			: base()
		{
		}
	}

	public class UnlockableAndNotRedactedCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public UnlockableAndNotRedactedCrateFilter()
			: base()
		{
		}
	}

	public class UnlockedAndNotRedactedCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public UnlockedAndNotRedactedCrateFilter()
			: base()
		{
		}
	}

	public class UnlockedCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public UnlockedCrateFilter()
			: base()
		{
		}
	}

	public class NonAvatarCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public NonAvatarCrateFilter()
			: base()
		{
		}
	}

	public class NonRedactedCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public NonRedactedCrateFilter()
			: base()
		{
		}
	}

	public class NonUnlockableCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public NonUnlockableCrateFilter()
			: base()
		{
		}
	}

	public class RedactedCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public RedactedCrateFilter()
			: base()
		{
		}
	}

	public class UnlockableCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public UnlockableCrateFilter()
			: base()
		{
		}
	}

	public class SpecialAvatarCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public SpecialAvatarCrateFilter()
			: base()
		{
		}
	}

	public class DevToolCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public DevToolCrateFilter()
			: base()
		{
		}
	}

	public class FavoritesCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public FavoritesCrateFilter()
			: base()
		{
		}
	}

	public class GunCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public GunCrateFilter()
			: base()
		{
		}
	}

	public class NPCCrateFilter : ICrateFilter<Crate>
	{
		public bool Filter(Crate crate)
		{
			return default(bool);
		}

		public NPCCrateFilter()
			: base()
		{
		}
	}

	private static List<string> specialAvatarsBarcodes;

	private static PlayerUnlocks u
	{
		get
		{
			return null;
		}
	}

	private static PlayerSettings p
	{
		get
		{
			return null;
		}
	}

	public CrateFilters()
		: base()
	{
	}
}
