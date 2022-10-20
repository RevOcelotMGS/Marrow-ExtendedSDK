using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Marrow_ExtendedSDK.StubClasses {
    public class InputControlAttribute : Attribute {
        public string[] aliases { get; set; }
        public uint offset { get; set; }
        public string usage { get; set; }
        public bool noisy { get; set; }
        public string alias { get; set; }
    }
}
