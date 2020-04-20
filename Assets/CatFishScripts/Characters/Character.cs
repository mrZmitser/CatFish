using System;
using System.Text;

namespace CatFishScripts.Characters {
    class Character : IComparable {

        static private uint nextId = 1;
        public string Name {
            get;
        }
        public uint Id {
            get;
        }
        public enum ConditionType { invulnerable, healthy, weakened, ill, poisoned, paralyzed, dead };
        private ConditionType _condition;
        public ConditionType Condition {
            get {
                return _condition;
            }
            set {
                _condition = value;
                checkCondition();
            }
        }
        public bool isTalkable {
            get;
            set;
        }
        public bool isMovable {
            get;
            set;
        }
        public enum RaceType {human, gnome, elf, orc, goblin };
        public RaceType Race {
            get;
        }
        public enum GenderType { male, female };
        public GenderType Gender {
            get;
        }
        public uint Age {
            get;
            set;
        }

        private uint _hp;
        public uint Hp {
            get {
                return _hp;
            }
            set {
                if ((int)value <= 0) {
                    value = 0;
                }
                _hp = value;
                if (_hp > MaxHp) {
                    _hp = MaxHp;
                }
                checkCondition();
            }
        }
        private void checkCondition() {
            if (Condition != ConditionType.healthy && Condition == ConditionType.weakened 
                && Condition == ConditionType.dead) {
                return;
            }
            if (Hp == 0) {
                _condition = ConditionType.dead;
            }
            if (Hp > 0 && Hp < 10) {
                _condition = ConditionType.weakened;
            }
            if (Hp >= 10) {
                _condition = ConditionType.healthy;
            }
        }
        public uint MaxHp {
            get;
            set;
        }
        public uint Xp {
            get;
            set;
        }
        public Inventory.Inventory Inventory {
            get;
            private set;
        }
        public Character(string name, Inventory.Inventory inventory, RaceType race, GenderType gender,  uint age, 
            uint maxHp, uint hp, uint xp = 0, bool isTalkable = true, bool isMovable = true) {
            this.Name = name;
            this.Id = nextId++;
            this.isTalkable = isTalkable;
            this.isMovable = isMovable;
            this.Race = race;
            this.Age = age;
            this.MaxHp = maxHp;
            this.Hp = hp;
            this.Xp = xp;
            this.Gender = gender;
            this.Inventory = inventory;
        }
        public int CompareTo(object obj) {
            if (!(obj is Character)) {
                throw new ArgumentException("Wrong type : Character object expected");
            }
            Character tmp = obj as Character;
            if (this.Xp < tmp.Xp) {
                return -1;
            }
            if (this.Xp > tmp.Xp) {
                return 1;
            }
            return 0;
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
            s.Append("is Talkable : " + this.isTalkable.ToString() + "\n");
            s.Append("is Movable : " + this.isMovable.ToString());
          //  s.Append("is Inventory : " + this.inventory.ToString()); это не уверен что сюда но добавил чтобы не забыть если сюда.
            return s.ToString();
        }


    }

    
}
