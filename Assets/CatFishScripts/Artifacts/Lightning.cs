namespace CatFishScripts.Artifacts {
    abstract class Lightning : Artifact {
        public Lightning(uint power) : base(power, true) { }
        public override void Activate(Characters.Character character, uint power) {
            if (power > 0) {
                this.Power -= power;
                character.Hp -= power;
            }
        }
    }
}
