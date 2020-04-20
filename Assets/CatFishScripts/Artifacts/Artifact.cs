using CatFishScripts.Characters;

namespace CatFishScripts.Artifacts {
    abstract class Artifact : IMagic {
        //Сила артефакта
        public uint Power {
            get;
            set;
        }
        //"Восстанавливаемость" артефакта
        public bool IsRechargeable {
            get;
            set;
        }

        //конструктор
        public Artifact(uint power, bool isRechargeable) {
            this.Power = power;
            this.IsRechargeable = isRechargeable;
        }

        //абстрактный метод активации артефакта
        public abstract void OnCast(Character character, uint power);
        //Реализация интерфейса IMagic (выполнение артефакта)
        public  void Cast(CharacterMagician initiator = null, Character character = null, uint power = 0) {
            OnCast(character, power);
        }
    }
}

