using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFishScripts.Artifacts {
    abstract class Artifact {

        public enum KindType { armor, weapon, other };

        public KindType Kind
        {
            get;
        }

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


        //Конструктор
        protected Artifact(uint power, bool isRechargeable) {
            this.Power = power;
            this.IsRechargeable = isRechargeable;
        }


    }
}
