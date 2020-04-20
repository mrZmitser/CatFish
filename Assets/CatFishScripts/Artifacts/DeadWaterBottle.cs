using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    class DeadWaterBottle : Bottle {
        public DeadWaterBottle(VolumeType volume) : base(0, false, volume) { }
        public override void Activate(Character character, uint power = 0) {
            (character as CharacterMagician).Mana += (uint) this.Volume;
        }
    }
}
