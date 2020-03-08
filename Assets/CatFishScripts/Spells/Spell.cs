using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

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
        public abstract void onCast(CharacterMagician character, uint power);
        //Реализация интерфейса IMagic (выполнение заклинания)
        public void castSpell(CharacterMagician character, uint power) {
            if (power > character.Mana) {
                throw new ArgumentException("Not enough mana");
            }
            onCast(character, power);
            if (this.HasPower) {
                character.Mana -= Cost * power;
            } else {
                character.Mana -= Cost;
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
