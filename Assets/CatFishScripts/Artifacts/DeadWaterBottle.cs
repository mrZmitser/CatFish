using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    class DeadWaterBottle : Bottle {
        public DeadWaterBottle(VolumeType volume) : base(0, false, volume) { }
        public override void OnCast(Character character, uint power = 0) {
            (character as CharacterMagician).Mana += (uint)this.Volume;
        }
    }
}
