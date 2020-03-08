using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

namespace CatFishScripts.Spells {
    class Antidote : Spell{
        public Antidote(uint cost = 30, bool isVerbal = false, bool isMotor = false, bool hasPower = false)
            : base(cost, isVerbal, isMotor, hasPower) { }
        public override void onCast(CharacterMagician character, uint power) {
            if (character.Condition == Character.ConditionType.poisoned) {
                character.Condition = Character.ConditionType.healthy;
            }
        }

    }
}
