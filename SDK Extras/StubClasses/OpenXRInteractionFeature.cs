using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Marrow_ExtendedSDK.StubClasses {
    public abstract class OpenXRInteractionFeature {

		protected bool OnInstanceCreate(ulong xrInstance)
		{
			return default(bool);
		}

		protected void RegisterActionMapsWithRuntime()
		{
		}

        protected void RegisterDeviceLayout() {
        }

		protected void UnregisterDeviceLayout()
		{
		}
    }
}
