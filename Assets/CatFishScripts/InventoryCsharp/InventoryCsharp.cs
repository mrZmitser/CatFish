using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Artifacts;
using CatFishScripts.Spells;
using CatFishScripts.Characters;

namespace CatFishScripts.InventoryCsharp
{
    class Inventory
    {        
        public List<List<Artifact>> _artifact
        {
            get;  
        }
        
        public List<Spell> _spell
        {
            get;
        }
        public void AddArtifact(Artifact artifact)
        {
            int _Type = Convert.ToInt32(artifact.Kind);
            _artifact[_Type].Add(artifact);
        }
        public void RemoveArtifact(Artifact artifact)
        {
            int _Type = Convert.ToInt32(artifact.Kind);
            _artifact[_Type].Remove(artifact);
        }
        public void AddSpell(Spell spell)
        {
            _spell.Add(spell);
        }
        public void RemoveSpell(Spell spell)
        {
            _spell.Remove(spell);
        }
        public void ExchangeArtifact(Character man1, Character man2, Artifact artifact)
        {
            man1.inventory.RemoveArtifact(artifact);
            man2.inventory.AddArtifact(artifact);
        }
        public void ExchangeSpell(Character man1, Character man2, Spell spell)
        {
            man1.inventory.RemoveSpell(spell);
            man2.inventory.AddSpell(spell);
        }
    }
}
