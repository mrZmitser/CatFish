﻿namespace CatFishScripts.Spells {
    class Revive : Spell {
        public Revive() : base(150, false, false, false) { }
        public override void OnCast(Characters.Character character, uint power) {
            if (character.Condition == Characters.Character.ConditionType.paralyzed) {
                character.Hp = 1;
                character.Condition = Characters.Character.ConditionType.healthy;
            }
        }
    }
}
