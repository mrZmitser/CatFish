namespace CatFishScripts.Characters {
    class CharacterMagician : Character {
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

        public CharacterMagician(string name, RaceType race, GenderType gender,
            uint age, uint maxHp, uint hp, uint mana, uint maxMana,
            uint xp = 0, bool isTalkable = true, bool isMovable = true)
             : base(name, race, gender, age, maxHp, hp, xp, isTalkable, isMovable) {
            this.Mana = mana;
            this.MaxMana = maxMana;
            this.SpellsList = new Inventory.SpellsList(this);

        }

    }
}
