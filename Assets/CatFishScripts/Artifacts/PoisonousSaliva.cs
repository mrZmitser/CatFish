namespace CatFishScripts.Artifacts {
    class PoisounousSaliva : Artifact {
        public PoisounousSaliva(uint power) : base(power, true, true) { }
        protected override void OnCast(Characters.Character character, uint power) {
            if (character.Condition != Characters.Character.ConditionType.invulnerable) {
                character.Hp -= power;
            }
            this.Power -= power;
            if (character.Condition == Characters.Character.ConditionType.healthy ||
                character.Condition == Characters.Character.ConditionType.weakened) {
                character.Condition = Characters.Character.ConditionType.poisoned;
            }
            
        }
    }
}
