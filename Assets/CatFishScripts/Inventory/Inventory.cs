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
        public bool RemoveArtifact(int index) {
            if (index < 0 || index >= Artifacts.Count)
                throw new KeyNotFoundException("There is no such index");
            return Artifacts.Remove(Artifacts[index]);
        }
        public void ExchangeArtifact(Character recipient, int index) {
            Artifact artifact;
            try {
                artifact = Artifacts[index];
            } catch {
                throw new KeyNotFoundException("There is no such index");
            }
            this.RemoveArtifact(index);
            recipient.Inventory.AddArtifact(artifact);
        }
        public bool ActivateArtifact(int index, Character character, uint power = 0) {
            if (index < 0 || index >= Artifacts.Count)
                throw new KeyNotFoundException("There is no such index");
            Artifacts[index].Cast(null, character, power);
            if (!Artifacts[index].IsRechargeable) {
                this.RemoveArtifact(index);
            }
            return true;
        }
    }
}
