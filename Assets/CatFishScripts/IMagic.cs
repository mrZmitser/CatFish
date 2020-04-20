namespace CatFishScripts {
    interface IMagic {
        void Cast(Characters.CharacterMagician initiator = null, Characters.Character character = null, uint power = 0);
    }
}
