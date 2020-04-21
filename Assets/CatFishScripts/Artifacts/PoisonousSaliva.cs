namespace CatFishScripts.Artifacts {
    abstract class PoisounousSaliva : Artifact {
        public PoisounousSaliva(uint power) : base(power, true, true) { }
        protected override void OnCast(Characters.Character character, uint power) {
            if (character.Condition == Characters.Character.ConditionType.healthy ||
                character.Condition == Characters.Character.ConditionType.weakened) {
                character.Condition = Characters.Character.ConditionType.poisoned;
            }
            character.Hp -= power;
        }
    }
}
