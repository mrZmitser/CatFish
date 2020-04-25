using CatFishScripts.Spells;
using CatFishScripts.Characters;
using System.Collections.Generic;

namespace CatFishScripts.Inventory {
    class SpellsList {
        public List<Spell> Spells {
            get;
            private set;
        }
        Magician Owner {
            get;
        }
        public SpellsList(Characters.Magician owner) {
            Spells = new List<Spell>();
            Owner = owner;
        }
        public void AddSpell(Spell spell) {
            if (Owner.Condition == Character.ConditionType.dead) {
                throw new System.AggregateException("The initiator cannot be dead");
            }
            Spells.Add(spell);
        }
        public bool RemoveSpell(int index) {
            return Spells.Remove(Spells[index]);
        }
        public bool CastSpell(int index, Character character, uint power) {
            if (Owner.Condition == Character.ConditionType.dead) {
                throw new System.AggregateException("The initiator cannot be dead");
            }
            if (index < 0 || index >= Spells.Count)
                throw new KeyNotFoundException("There is no such index");
            if (Spells[index].HasPower) {
                Spells[index].Cast(Owner, character, power);
            } else {
                Spells[index].Cast(Owner, character);
            }
            return true;
        }
    }
}
