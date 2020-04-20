namespace CatFishScripts.Artifacts {
    abstract class Decoctum : Artifact {
        public Decoctum() : base(0, false) { }
        public override void OnCast(Characters.Character character, uint power) {
            if (character.Condition == Characters.Character.ConditionType.poisoned) {
                character.Condition = Characters.Character.ConditionType.healthy;
            }
        }
    }
}
