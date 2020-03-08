using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFishScripts.Spells {
    interface IMagic {
        void castSpell(Characters.CharacterMagician character = null, uint power = 0);
    }
}
