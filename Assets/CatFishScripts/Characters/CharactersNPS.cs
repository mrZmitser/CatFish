using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.InventoryCsharp;

namespace CatFishScripts.Characters
{
    class CharactersNPS
    {
        static private uint nextId = 1;
        public string Name
        {
            get;
        }
        public uint Id
        {
            get;
        }
        
       
        public bool isTalkable
        {
            get;
            set;
        }
        public bool isMovable
        {
            get;
            set;
        }
        public enum RaceType { human, gnome, elf, orc, goblin };
        public RaceType Race
        {
            get;
        }
        public enum GenderType { male, female };
        public GenderType Gender
        {
            get;
        }
        public uint Age
        {
            get;
            set;
        }
        public uint MaxHp
        {
            get;
            set;
        }
        public Inventory inventory = new Inventory();
        public CharactersNPS(string name, Inventory _inventory, RaceType race, GenderType gender, uint age,
           uint maxHp, bool isTalkable = true, bool isMovable = true)
        {
            this.Name = name;
            this.Id = nextId++;
            this.isTalkable = isTalkable;
            this.isMovable = isMovable;
            this.Race = race;
            this.Age = age;
            this.MaxHp = maxHp;
            this.Gender = gender;
            this.inventory = _inventory;
        }
        
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("id : " + this.Id.ToString() + "\n");
            s.Append("name : " + this.Name + "\n");
            s.Append("race : " + this.Race.ToString() + "\n");
            s.Append("gender : " + this.Gender.ToString() + "\n");
            s.Append("age : " + this.Age.ToString() + "\n");
            s.Append("max HP : " + this.MaxHp.ToString() + "\n");
            s.Append("is Talkable : " + this.isTalkable.ToString() + "\n");
            s.Append("is Movable : " + this.isMovable.ToString());
            //  s.Append("is Inventory : " + this.inventory.ToString()); это не уверен что сюда но добавил чтобы не забыть если сюда.
            return s.ToString();
        }
    }
}
