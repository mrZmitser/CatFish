using System;
using System.Threading;

namespace CatFishScripts.Spells {
    class Armor : Spell {
        int power;
        public Armor() : base(50, false, true, true) { }
        protected override void OnCast(Characters.Character character, uint power) {
            if (character.Condition == Characters.Character.ConditionType.invulnerable) {
                throw new TypeAccessException("Character is already invulnerable");
            }
            if (character.Condition == Characters.Character.ConditionType.dead) {
                throw new ArgumentException("Character cannot be dead");
            }
            this.power = (int)power;
            var condition = character.Condition;
            character.Condition = Characters.Character.ConditionType.invulnerable;
            Thread waitingThread = new Thread(LockCondition);
            character.Condition = condition;
        }
        private void LockCondition() {
            Thread.Sleep(2000 * power);
        }
    }
}

