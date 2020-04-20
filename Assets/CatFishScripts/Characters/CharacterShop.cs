using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.Inventory;


namespace CatFishScripts.Characters
{
    class CharacterShop: CharactersNPC
    {
        public List<int> Prices {
            get;   
        }
       
        

        public CharacterShop(string name, Inventory inventory, List<int> prices, RaceType race, GenderType gender, uint age,
            uint maxHp, bool isTalkable = true, bool isMovable = true)
             : base(name, inventory, race, gender, age, maxHp, isTalkable, isMovable) {
            this.Prices = prices;
        }
       
    }
}
