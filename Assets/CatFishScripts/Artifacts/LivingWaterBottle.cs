using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    class LivingWaterBottle : Bottle {
        public LivingWaterBottle(VolumeType volume) : base(0, false, volume) { }

        protected override void OnCast(Character character, uint power = 0) {
            if (character.Condition != Character.ConditionType.dead) {
                character.Hp += (uint)this.Volume;
            }
        }
    }
}
