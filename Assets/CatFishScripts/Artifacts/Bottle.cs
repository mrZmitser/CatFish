﻿namespace CatFishScripts.Artifacts {
    abstract class Bottle : Artifact {
        public enum VolumeType { Small = 10, Medium = 25, Big = 50 };
        public VolumeType Volume {
            get;
            set;
        }
        public Bottle(uint power, bool isRechargeable, VolumeType volume)
            : base(power, isRechargeable) {
            Volume = volume;
        }
        abstract public override void Cast(Characters.CharacterMagician magician = null,
            Characters.Character character = null, uint power = 0);
    }
}