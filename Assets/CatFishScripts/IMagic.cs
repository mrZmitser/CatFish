namespace CatFishScripts {
    interface IMagic {
        void Cast(Characters.CharacterMagician initiator, Characters.Character influenced, uint power);
        void Cast(Characters.Character influenced, uint power);
        void Cast(Characters.CharacterMagician initiator, Characters.Character influenced);
        void Cast(Characters.Character influenced);
    }
}
