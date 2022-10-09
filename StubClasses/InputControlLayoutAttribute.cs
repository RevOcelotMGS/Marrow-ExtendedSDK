using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Marrow_ExtendedSDK.StubClasses {
    public class InputControlLayoutAttribute : Attribute {
        public bool isGenericTypeOfDevice { get; set; }
        public string displayName { get; set; }
        public string[] commonUsages { get; set; }
    }
}
