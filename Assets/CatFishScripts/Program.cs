using CatFishScripts.Characters;
using System;

namespace CatFishScripts {
    /*
     * Задача:
     * Описать объявленные ниже функции.
     * Опираться при этом на скинутый ПДФ
     * По вопросам -- пишите.
     */
    class Program {
        static CharacterMagician ReadInfoAboutMagicianFromConsole() {

            // ...
            return new CharacterMagician(...);
        }
        static Character ReadInfoAboutCharacterFromConsole() {

            // ...
            return new Character(...);
        }
        static void ShowDialog() {
            Console.WriteLine("Даров всем, введите:");
            Console.WriteLine("Состояние ваших персонажей:");
            //вывод состояния и здоровья каждого персонажа
            int a = Int32.Parse(Console.ReadLine());
            switch (a) {
                case 1:
                    // do smth
                    break;
                case 2:
                    // do smth 
                    break;
                //........
                default:
                    Console.WriteLine("Такой команды не существует, попробуйте ещё раз");
                    break;
            }
        }

        static void Main(string[] args) {
            CharacterMagician mainCharacter = ReadInfoAboutMagicianFromConsole();
            Character satellite = ReadInfoAboutCharacterFromConsole();
            /*
             * Тут объявления врагов, можно вынести в функцию 
             */
            ShowDialog();
        }
    }
}
