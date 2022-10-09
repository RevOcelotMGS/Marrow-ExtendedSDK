using System;

namespace Assets.Marrow_ExtendedSDK.StubClasses {
    public class OpenXRFeature {
        protected virtual bool OnInstanceCreate(ulong xrInstance) {
            return default(bool);
        }

        protected virtual void OnInstanceDestroy(ulong xrInstance) {
        }

        protected virtual void OnSessionBegin(ulong xrSession) {
        }

        protected virtual void OnSessionDestroy(ulong xrSession) {
        }

        protected virtual void OnSessionEnd(ulong xrSession) {
        }
        protected virtual IntPtr HookGetInstanceProcAddr(IntPtr func) {
            return default(IntPtr);
        }
    }
}
