using CatFishScripts.Artifacts;
using CatFishScripts.Characters;
using System.Collections.Generic;

namespace CatFishScripts.Inventory {
    class Inventory {
        public List<Artifact> Artifacts {
            get;
            private set;
        }

        public Inventory() {
            Artifacts = new List<Artifact>();
        }
        public void AddArtifact(Artifact artifact) {
            Artifacts.Add(artifact);
        }
        public bool RemoveArtifact(Artifact artifact) {
            return Artifacts.Remove(artifact);
        }
        public void ExchangeArtifact(Character recipient, Artifact artifact) {
            this.RemoveArtifact(artifact);
            recipient.Inventory.AddArtifact(artifact);
        }
        public bool ActivateArtifact(Artifact artifact, Character character, uint power = 0) {
            int i = Artifacts.IndexOf(artifact);
            if (i == -1) {
                return false;
            }
            artifact.Cast(null, character, power);
            if (!artifact.IsRechargeable) {
                this.RemoveArtifact(artifact);
            }
            return true;
        }
    }
}
