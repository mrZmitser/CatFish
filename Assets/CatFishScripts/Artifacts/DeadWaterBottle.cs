using CatFishScripts.Characters;
using System;

namespace CatFishScripts.Artifacts {
    class DeadWaterBottle : Bottle {
        public DeadWaterBottle(VolumeType volume) : base(0, false, volume) { }
        protected override void OnCast(Character character, uint power = 0) {
            if (character.GetType() != typeof(Magician)) {
                throw new ArgumentException("You can only cast this artifact on magicians");
            }
            if (character.Condition != Character.ConditionType.dead) {
                (character as Magician).Mana += (uint)this.Volume;
            }
        }
    }
}
