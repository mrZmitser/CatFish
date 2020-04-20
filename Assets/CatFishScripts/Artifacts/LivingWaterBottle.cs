using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    class LivingWaterBottle : Bottle {
        public LivingWaterBottle(VolumeType volume) : base(0, false, volume) { }

        public override void OnCast(Character character, uint power = 0) {
            character.Hp += (uint)this.Volume;
        }
    }
}
