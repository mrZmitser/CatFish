using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Spells;

namespace CatFishScripts.Inventory {
    class SpellsList {
        private List<Spell> Spells {
            get;
            set;
        }
        public void AddSpell(Spell spell) {
            Spells.Add(spell);
        }
        public bool RemoveSpell(Spell spell) {
            return Spells.Remove(spell);
        }
        public bool CastSpell(uint index) {
            try {
                Spells[index].castSpell(;
            } catch {
                return false;
            }

            return true;
        }
    }
}
