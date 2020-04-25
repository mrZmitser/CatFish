using System;

namespace CatFishScripts.Artifacts {
    class Lightning : Artifact {
        public Lightning(uint power) : base(power, true, true) { }
        protected override void OnCast(Characters.Character character, uint power) {
            if (this.Power > 0 && character.Condition != Characters.Character.ConditionType.invulnerable) {
                this.Power -= Math.Min(power, this.Power);
                character.Hp -= Math.Min(power, this.Power);
            }
        }
    }
}
