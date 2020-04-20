namespace CatFishScripts.Artifacts {
    abstract class PoisounousSaliva : Artifact {
        public PoisounousSaliva (uint power) : base(KindType.weapon, power, true) { }
        public override void Activate(Characters.Character character, uint power) {
            if (character.Condition == Characters.Character.ConditionType.healthy ||
                character.Condition == Characters.Character.ConditionType.weakened) {
                character.Condition = Characters.Character.ConditionType.poisoned;
            }
            character.Hp -= power;
        }
    }
}
