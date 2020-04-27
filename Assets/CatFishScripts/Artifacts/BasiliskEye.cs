using CatFishScripts.Characters;
using System;

namespace CatFishScripts.Artifacts {
    class BasiliskEye : Artifact {
        public BasiliskEye() : base(0, false, false) { }

        protected override void OnCast(Character character, uint power) {
            if (character.Condition == Character.ConditionType.dead) {
                throw new ArgumentException("Character cannot be dead");
            }
            character.Condition = Character.ConditionType.paralyzed;
        }
    }
}
