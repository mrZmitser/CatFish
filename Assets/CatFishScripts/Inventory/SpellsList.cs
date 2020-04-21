using CatFishScripts.Spells;
using System.Collections.Generic;

namespace CatFishScripts.Inventory {
    class SpellsList {
        private List<Spell> Spells {
            get;
            set;
        }
        Characters.CharacterMagician Owner {
            get;
        }
        public SpellsList(Characters.CharacterMagician owner) {
            Spells = new List<Spell>();
            Owner = owner;
        }
        public void AddSpell(Spell spell) {
            Spells.Add(spell);
        }
        public bool RemoveSpell(int index) {
            return Spells.Remove(Spells[index]);
        }
        public bool CastSpell(int index, Characters.Character character, uint power) {
            if (index < 0 || index >= Spells.Count)
                throw new KeyNotFoundException("There is no such index");
            Spells[index].Cast(Owner, character, power);
            return true;
        }
    }
}
