using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

namespace CatFishScripts.Spells {
    class AddHealth : Spell {
        public AddHealth(uint cost = 2, bool isVerbal = false, bool isMotor = false, bool hasPower = true)
            : base(cost, isVerbal, isMotor, hasPower) { }
        public override void onCast(CharacterMagician character, uint power) {
            character.Hp += power;
        }
    }
}
