using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFishScripts.InventoryCsharp;


namespace CatFishScripts.Characters
{
    class CharacterShop: CharactersNPS
    {
        public List<int> prices
        {
            get;   
        }
       
        

        public CharacterShop(string name, Inventory _inventory, List<int> price, RaceType race, GenderType gender, uint age,
            uint maxHp, bool isTalkable = true, bool isMovable = true)
             : base(name, _inventory, race, gender, age, maxHp, isTalkable, isMovable)
        {
            this.prices = price;
            
        }
       
    }
}
