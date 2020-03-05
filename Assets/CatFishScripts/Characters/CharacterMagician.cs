using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFishScripts.Characters {
    class CharacterMagician : Character {
        uint Mana {
            get;
            set;
        }

        uint MaxMana {
            get;
            set;
        }

        public CharacterMagician(string name, RaceType race, GenderType gender, uint age,
            uint maxHp, uint hp, uint xp = 0, bool isTalkable = true, bool isMovable = true)
             : base(name, race, gender, age, maxHp, hp, xp, isTalkable, isMovable) { 
            
        }
    }
}
