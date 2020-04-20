using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    class BasiliskEye : Artifact {
        public BasiliskEye() : base(0, false) {}

        public override void Activate(Character character, uint power = 0) {
            if (character.Condition != Character.ConditionType.dead) {
                character.Condition = Character.ConditionType.paralyzed;
            }
        }
    }
}
