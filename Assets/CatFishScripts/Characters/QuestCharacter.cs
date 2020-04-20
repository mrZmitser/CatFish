using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.InventoryCsharp;

namespace CatFishScripts.Characters
{
    class QuestCharacter: CharactersNPC
    {
        public enum QuestProgress { completed, fresh, in_process };
        public QuestProgress QuestType
        {
            get;
        }

        public List<QuestProgress> Quest
        {
            get;   
        }
        public void AddQuest(QuestProgress QuestType)
        {    
                Quest.Add(QuestType);
        }
        public QuestCharacter(string name, Inventory _inventory, QuestProgress quests, List<QuestProgress> questlist, RaceType race, GenderType gender, uint age,
            uint maxHp, bool isTalkable = true, bool isMovable = true)
             : base(name, _inventory, race, gender, age, maxHp, isTalkable, isMovable )
        {
            this.Quest = questlist;
        }
        
    }
}
