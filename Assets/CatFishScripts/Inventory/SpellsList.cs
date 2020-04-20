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
        public bool RemoveSpell(Spell spell) {
            return Spells.Remove(spell);
        }
        public bool CastSpell(Spell spell, Characters.Character character, uint power) {
            int i = Spells.IndexOf(spell);
            if (i == -1) {
                return false;
            }
            spell.Cast(Owner, character, power);
            return true;
        }
    }
}
