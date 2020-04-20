using CatFishScripts.Characters;

namespace CatFishScripts.Spells {
    class AddHealth : Spell {
        public AddHealth() : base(2, false, false, true) { }
        public override void OnCast(Character character, uint power) {
            character.Hp += power;
        }
    }
}
