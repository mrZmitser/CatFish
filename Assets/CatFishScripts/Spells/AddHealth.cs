using CatFishScripts.Characters;
using System;

namespace CatFishScripts.Spells {
    class AddHealth : Spell {
        public AddHealth() : base(2, true, false, true) { }
        protected override void OnCast(Character character, uint power) {
            if (character.Condition == Character.ConditionType.dead) {
                throw new ArgumentException("Character cannot be dead");
            }
            character.Hp += power;
        }
    }
}
