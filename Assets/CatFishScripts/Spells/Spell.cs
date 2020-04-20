using CatFishScripts.Characters;
using System;

namespace CatFishScripts.Spells {
    abstract class Spell : IMagic {
        //Минимальное значение маны для выполнения заклинания
        public uint Cost {
            get;
            set;
        }
        //Наличие вербальной компоненты
        public bool IsVerbal {
            get;
            set;
        }
        //Наличие моторной компоненты
        public bool IsMotor {
            get;
            set;
        }
        //Имеет ли заклинание силу
        public bool HasPower {
            get;
            set;
        }
        //
        public abstract void OnCast(Character character, uint power);
        //Реализация интерфейса IMagic (выполнение заклинания)
        public void Cast(CharacterMagician initiator, Character character = null, uint power = 0) {
            if (power > initiator.Mana) {
                throw new ArgumentException("Not enough mana");
            }
            OnCast(character, power);
            if (this.HasPower) {
                initiator.Mana -= Cost * power;
            } else {
                initiator.Mana -= Cost;
            }
        }

        //Конструктор
        public Spell(uint cost, bool isVerbal, bool isMotor, bool hasPower) {
            this.Cost = cost;
            this.IsVerbal = isVerbal;
            this.IsMotor = isMotor;
            this.HasPower = hasPower;
        }
    }
}
