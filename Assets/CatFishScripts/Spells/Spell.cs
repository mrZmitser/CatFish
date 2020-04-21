﻿using CatFishScripts.Characters;
using System;

namespace CatFishScripts.Spells {
    abstract class Spell : IMagic {
        //Минимальное значение маны для выполнения заклинания
        public uint Cost {
            get;
        }
        //Наличие вербальной компоненты
        public bool IsVerbal {
            get;
        }
        //Наличие моторной компоненты
        public bool IsMotor {
            get;
        }
        //Имеет ли заклинание силу
        public bool HasPower {
            get;
        }
        //
        protected abstract void OnCast(Character character, uint power);
        //Реализация интерфейса IMagic (выполнения заклинания)
        public void Cast(CharacterMagician initiator, Character character, uint power) {
            if (initiator.Condition == Character.ConditionType.dead) {
                throw new ArgumentException("Initiator cannot be dead");
            }
            if (!this.HasPower) {
                throw new ArgumentException("Using power for a spell that does not have a power");
            }
            if (Cost*power > initiator.Mana) {
                throw new ArgumentException("Not enough mana");
            }
            OnCast(character, power);
            initiator.Mana -= Cost * power;
        }
        public void Cast(CharacterMagician initiator, Character character) {
            if (initiator.Condition == Character.ConditionType.dead) {
                throw new ArgumentException("Initiator cannot be dead");
            }
            if (this.HasPower) {
                throw new ArgumentException("Using power for a spell that does not have a power");
            }
            if (Cost > initiator.Mana) {
                throw new ArgumentException("Not enough mana");
            }
            OnCast(character, 0);
            initiator.Mana -= Cost;
        }
        public void Cast(Character character, uint power) {
            throw new NotImplementedException("The spell cannot exist without initiator");
        }
        public void Cast(Character character) {
            throw new NotImplementedException("The spell cannot exist without initiator");
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
