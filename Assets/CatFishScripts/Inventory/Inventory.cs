using System;
using System.Collections.Generic;
using CatFishScripts.Artifacts;
using CatFishScripts.Spells;
using CatFishScripts.Characters;

namespace CatFishScripts.Inventory
{
    class Inventory
    {        
        public List<List<Artifact>> Artifacts
        {
            get;
            private set;
        }
        
  
        public Inventory() {
            Artifacts = new List<List<Artifact>>(Enum.GetNames(typeof(Artifact.KindType)).Length);

        }
        public void AddArtifact(Artifact artifact)
        {
            int type = (int)artifact.Kind;
            Artifacts[type].Add(artifact);
        }
        public bool RemoveArtifact(Artifact artifact)
        {
            int type = (int)artifact.Kind;
            return Artifacts[type].Remove(artifact);
        }
     
        public void ExchangeArtifact(Character recipient, Artifact artifact) {
            this.RemoveArtifact(artifact);
            recipient.Inventory.AddArtifact(artifact);
        }
        public bool ActivateArtifact(Artifact artifact, Character character, uint power = 0) {
            int type = (int)artifact.Kind;
            int i = Artifacts[type].IndexOf(artifact);
            if (i == -1) {
                return false;
            }
            artifact.Activate(character, power);
            if (!artifact.IsRechargeable) {
                this.RemoveArtifact(artifact);
            }
            return true;
        }
    }
}
