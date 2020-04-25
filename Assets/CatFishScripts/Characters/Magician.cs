using System.Text;

namespace CatFishScripts.Characters {
    class Magician : Character {
        public uint Mana {
            get;
            set;
        }

        public uint MaxMana {
            get;
            set;
        }
        public Inventory.SpellsList SpellsList {
            get;
        }

        public Magician(string name, RaceType race, GenderType gender,
            uint age, uint maxHp, uint hp, uint mana, uint maxMana,
            uint xp = 0, bool isTalkable = true, bool isMovable = true)
             : base(name, race, gender, age, maxHp, hp, xp, isTalkable, isMovable) {
            this.Mana = mana;
            this.MaxMana = maxMana;
            this.SpellsList = new Inventory.SpellsList(this);

        }

        public override string ToString() {
            StringBuilder s = new StringBuilder();
            s.Append("id : " + this.Id.ToString() + "\n");
            s.Append("name : " + this.Name + "\n");
            s.Append("race : " + this.Race.ToString() + "\n");
            s.Append("gender : " + this.Gender.ToString() + "\n");
            s.Append("age : " + this.Age.ToString() + "\n");
            s.Append("max HP : " + this.MaxHp.ToString() + "\n");
            s.Append("HP : " + this.Hp.ToString() + "\n");
            s.Append("Condition : " + this.Condition.ToString() + "\n");
            s.Append("XP : " + this.Xp.ToString() + "\n");
            s.Append("is Talkable : " + this.IsTalkable.ToString() + "\n");
            s.Append("is Movable : " + this.IsMovable.ToString() + "\n");
            s.Append("Number of items : " + this.Inventory.Artifacts.Count.ToString() + '\n');
            s.Append("Number of spells : " + this.SpellsList.Spells.Count.ToString() + '\n');
            s.Append("Mana: " + this.Mana.ToString() + '\n');
            s.Append("MaxMana: " + this.MaxMana.ToString() + '\n');
            return s.ToString();
        }
    }
}
