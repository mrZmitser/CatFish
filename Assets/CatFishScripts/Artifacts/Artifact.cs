using CatFishScripts.Characters;
using System;

namespace CatFishScripts.Artifacts {
    abstract class Artifact : IMagic {
        //Сила артефакта
        public uint Power {
            get;
            protected set;
        }
        //"Восстанавливаемость" артефакта
        public bool IsRechargeable {
            get;
        }
        //Имеет ли силу
        public bool HasPower {
            get;
        }

        //конструктор
        public Artifact(uint power, bool isRechargeable, bool hasPower) {
            this.Power = power;
            this.IsRechargeable = isRechargeable;
            this.HasPower = hasPower;
        }

        //абстрактный метод активации артефакта
        protected abstract void OnCast(Character character, uint power);
        //Реализация интерфейса IMagic (выполнение артефакта)
        public  void Cast(Character character, uint power) {
            if (!this.HasPower) {
                throw new ArgumentException("This artifact can't have a power");
            }
            OnCast(character, power);
        }
        public void Cast(Character character) {
            if (this.HasPower) {
                throw new ArgumentException("This artifact must have a power");
            }
            OnCast(character, 0);
        }
        public void Cast(CharacterMagician initiator, Character character, uint power) {
            throw new NotImplementedException("The initiator is not needed");
        }
        public void Cast(CharacterMagician initiator, Character character) {
            throw new NotImplementedException("The initiator is not needed");
        }
        

    }
}

