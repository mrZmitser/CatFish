using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

namespace CatFishScripts.Spells {
    class Heal : Spell {
        public Heal(uint cost = 20, bool isVerbal = false, bool isMotor = false, bool hasPower = false)
            : base(cost, isVerbal, isMotor, hasPower) { }
        public override void onCast(CharacterMagician character, uint power) {
            if (character.Condition == Character.ConditionType.ill)
                character.Condition = Character.ConditionType.healthy;
        }
    }
}
