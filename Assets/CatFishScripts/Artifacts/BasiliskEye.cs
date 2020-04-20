using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    class BasiliskEye : Artifact {
        public BasiliskEye() : base(0, false) { }

        public override void OnCast(Character character = null, uint power = 0) {
            if (character.Condition != Character.ConditionType.dead) {
                character.Condition = Character.ConditionType.paralyzed;
            }
        }
    }
}
