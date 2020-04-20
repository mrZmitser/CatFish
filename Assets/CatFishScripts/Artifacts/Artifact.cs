namespace CatFishScripts.Artifacts {
    abstract class Artifact {
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
        //тип артефакта
        public enum KindType { weapon, armor, other };
        public KindType Kind {
            get;
            private set;
        }

        //Конструктор
        public Artifact(KindType kind, uint power, bool isRechargeable) {
            this.Power = power;
            this.IsRechargeable = isRechargeable;
            Kind = kind;
        }
        //Абстрактный метод активации артефакта -- у каждого артефакта свой
        abstract public void Activate(Characters.Character character, uint power = 0);
    }
}
