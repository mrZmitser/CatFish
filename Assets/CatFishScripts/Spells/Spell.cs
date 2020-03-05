using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Characters;

namespace CatFishScripts.Spells {
    abstract class Spell : IMagic {
        //Минимальное значение маны для выполнения заклинания
        uint Cost {
            get;
            set;
        }
        //Наличие вербальной компоненты
        bool IsVerbal {
            get;
            set;
        }
        //Наличие моторной компоненты
        bool IsMotor {
            get;
            set;
        }
        //Имеет ли заклинание силу
        bool HasPower {
            get;
            set;
        }
        //Реализация интерфейса IMagic (выполнение заклинания)
        abstract public void castSpell(Character character, uint power);


        //Конструктор
        protected Spell(uint cost, bool isVerbal, bool isMotor, bool hasPower) {
            this.Cost = cost;
            this.IsVerbal = isVerbal;
            this.IsMotor = isMotor;
            this.HasPower = hasPower;
        }

        //TODO:
        //1. Реализовать классы-наследники данного заклинания (ЛЁША)
    }
}
