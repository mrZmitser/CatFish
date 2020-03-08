using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CatFishScripts.Spells {
    class Armor : Spell {
            public Armor(uint cost = 50, bool isVerbal = false, bool isMotor = false, bool hasPower = true)
                : base(cost, isVerbal, isMotor, hasPower) { }
            public override void onCast(Characters.CharacterMagician character, uint power) {
                character.Condition = Characters.Character.ConditionType.invulnerable;
                Thread.Sleep(2000 * (int)power);
                character.Condition = Characters.Character.ConditionType.healthy;
            }
    }
}
