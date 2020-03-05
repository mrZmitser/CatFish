using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFishScripts.Spells {
    interface IMagic {
        void castSpell(Characters.Character character, uint power);
    }
}
