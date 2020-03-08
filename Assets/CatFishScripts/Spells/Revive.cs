using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFishScripts.Spells {
    class Revive : Spell {
        public Revive(uint cost = 150, bool isVerbal = false, bool isMotor = false, bool hasPower = false)
            : base(cost, isVerbal, isMotor, hasPower) { }
        public override void onCast(Characters.CharacterMagician character, uint power) {
            character.Hp = 1;
        }
    }
}
