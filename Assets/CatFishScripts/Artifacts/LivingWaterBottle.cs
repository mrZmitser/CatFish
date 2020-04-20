using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    class LivingWaterBottle : Bottle {
        public LivingWaterBottle(VolumeType volume) : base(0, false, volume) { }

        public override void Activate(Character character, uint power = 0) {
            character.Hp += (uint) this.Volume;
        }
    }
}
