using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFishScripts.Artifacts {
    abstract class Artifact {
        uint Power {
            get;
            set;
        }
        bool IsRechargeable {
            get;
        }
    }
}
