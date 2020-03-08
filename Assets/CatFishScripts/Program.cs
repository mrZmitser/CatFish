using System;
using CatFishScripts.Characters;

namespace CatFishScripts {
    class Program {
        static void Main(string[] args) {
            Character s = new Character("Zhora", Character.RaceType.elf, Character.GenderType.male, 10, 100, 80);
            Console.WriteLine("{0}, {1}", s.Hp, s.Condition.ToString());
            s.Hp -= 1000;
            Console.WriteLine("{0}, {1}", s.Hp, s.Condition.ToString());
            Console.WriteLine(s.ToString());
            Console.ReadKey();
            Spells.AddHealth ssss = new Spells.AddHealth(20, true, true, true);

        }
    }
}
