namespace CatFishScripts.Artifacts {
    class Lightning : Artifact {
        public Lightning(uint power) : base(power, true, true) { }
        protected override void OnCast(Characters.Character character, uint power) {
            if (power > 0 && character.Condition != Characters.Character.ConditionType.invulnerable) {
                this.Power -= power;
                character.Hp -= power;
            }
        }
    }
}
