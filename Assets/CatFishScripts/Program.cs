using CatFishScripts.Characters;
using CatFishScripts.Artifacts;
using CatFishScripts.Spells;
using System;

namespace CatFishScripts {
    /*
     * Задача:
     * Описать объявленные ниже функции.
     * Опираться при этом на скинутый ПДФ
     * По вопросам -- пишите.
     */

    class Program {
        static void ReadUInt(ref uint n, string msg, uint a = 0, uint b = UInt32.MaxValue)
        {
            bool isCorrectInput = false;
            while (!isCorrectInput)
            {
                Console.WriteLine(msg);
                try
                {
                    n = UInt32.Parse(Console.ReadLine());
                    if (n < a || n > b)
                    {
                        Console.WriteLine("Введённое число не соответсвует диапазону! Попробуйте ещё раз!");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Не удалось преобразовать строку. Попробуйте снова!");
                    continue;
                }
                isCorrectInput = true;
            }            
        }
        static CharacterMagician ReadInfoAboutMagicianFromConsole() {
            string name = null;
            uint age = 0, maxHp = 0, hp = 0, xp = 0, race = 0, gender = 0, mana = 0, maxMana = 0, isTalkable = 0, isMovable = 0;           
            Console.WriteLine("Создайте своего персонажа: ");
            Console.WriteLine("Укажите его имя: ");
            name = Console.ReadLine();
            ReadUInt(ref race, "Укажите его расу: Введите 0 - для человека, 1 - для гнома, 2 - для эльфа, 3 - для орка, 4 - для гоблина", 0, 4);
            ReadUInt(ref gender, "Укажите его пол: Ввелите 0 - для мужчины, 1 - для женщины", 0, 1);
            ReadUInt(ref age, "Укажите его возраст: ");
            ReadUInt(ref xp, "Укажите его xp: ");
            ReadUInt(ref hp, "Укажите его hp: ");
            ReadUInt(ref maxHp, "Укажите его максимальное hp: ");
            ReadUInt(ref isMovable, "Введите единицу, если персонаж может двигаться: ");
            ReadUInt(ref isTalkable, "Введите единицу, если персонаж может говорить: ");
            ReadUInt(ref mana, "Укажите его изначальное значение манны: ");
            ReadUInt(ref maxMana, "Укажите максимальное значение манны: ");            
            return new CharacterMagician(name, (Character.RaceType) race, (Character.GenderType) gender, age, maxHp, hp, mana, maxMana, xp, isTalkable == 1, isMovable == 1);
        }
        static void PrintActions()
        {
            Console.WriteLine("0. Справка:");
            Console.WriteLine("1. Переключиться на спутника");
            Console.WriteLine("2. Передать спутнику артефакт");
            Console.WriteLine("3. Использовать артефакт");
            Console.WriteLine("4. Использовать зелье");
            Console.WriteLine("5. Добавить артефакт");
            Console.WriteLine("6. Выбросить артефакт");
            Console.WriteLine("7. Добавить заклинание");
            Console.WriteLine("8. Забыть заклинание");
            Console.WriteLine("9. Узнать всю текущую информацию а персонаже");
            Console.WriteLine("10. Узнать hp и состояние здоровья персонажа");
            Console.WriteLine("11. Просмотреть инвентарь");
            Console.WriteLine("12. Просмотреть свитки с заклинаниями");
            Console.WriteLine("13.Выйти из программы");
        }
        static void TransferArtifact(Character character1, Character character2)
        {            
            GetInventoryInfo(character1);
            if (character1.Inventory.Artifacts.Count > 0)
            {
                uint i = 0;
                ReadUInt(ref i, "Введите номер артефакта, который вы хотите передать: ", 1, (uint)character1.Inventory.Artifacts.Count);
                character1.Inventory.ExchangeArtifact(character2, (int)i-1);
            }
        }
        static void CastArtifact(Character character1)
        {
            GetInventoryInfo(character1);
            if (character1.Inventory.Artifacts.Count > 0)
            {
                uint enemyIndex = 0;
                uint i = 0, power = 0;
                ReadUInt(ref i, "Введите номер артефакта, который вы хотите использовать: ", 1, (uint)character1.Inventory.Artifacts.Count);

                if (character1.Inventory.Artifacts[(int)i].HasPower)
                {
                    //Пересмотреть слюну!!!!!
                    ReadUInt(ref power, "Введите мощность: ", 1);
                }
                ReadUInt(ref i, "Введите номер врага, против которого вы хотите использовать артефакт: ", 1, (uint)enemies.Length);
                character1.Inventory.ActivateArtifact((int)i - 1, enemies[enemyIndex], power);
            }
        }
        static void CastSpell(CharacterMagician character1)
        {
            GetSpellsInfo(character1);
            if (character1.SpellsList.Spells.Count > 0)
            {
                uint enemyIndex = 0;
                uint i = 0, power = 0;
                ReadUInt(ref i, "Введите номер заклинания, который вы хотите использовать: ", 1, (uint)character1.SpellsList.Spells.Count);
                if (character1.SpellsList.Spells[(int)i].HasPower)
                {
                    ReadUInt(ref power, "Введите мощность: ", 1);
                }
                ReadUInt(ref i, "Введите номер врага, против которого вы хотите использовать заклинания: ", 1, (uint)enemies.Length);
                character1.SpellsList.CastSpell((int)i - 1, enemies[enemyIndex], power);
            }
        }
        static void AddArtifact(Character character)
        {
            uint n = 0, volume = 0, power = 0;
            ReadUInt(ref n, "Введите номер арткфакта, который хотите добавить: \n 1 - бутылка с живой водой, \n 2 - для бутылка с мёртвой водой,\n " +
                "3 - посох \"Молния\",\n 4 - декокт из лягушачьих лапок,\n 5 - ядовитая слюна,\n 6 - глаз василиска ", 1, 6);
            switch (n)
            {
                case 1:
                    ReadUInt(ref volume, "Введите объём бутылки: 0 - 10, 1 - 25, 2 - 50", 0, 2);
                    character.Inventory.AddArtifact(new LivingWaterBottle((Bottle.VolumeType)volume));
                    break;
                case 2:
                    ReadUInt(ref volume, "Введите объём бутылки: 0 - 10, 1 - 25, 2 - 50", 0, 2);
                    character.Inventory.AddArtifact(new DeadWaterBottle((Bottle.VolumeType)volume));
                    break;
                case 3:
                    ReadUInt(ref power, "Введите мощность посоха:");
                    character.Inventory.AddArtifact(new Lightning(power));
                    break;
                case 4:
                    character.Inventory.AddArtifact(new Decoctum());
                    break;
                case 5:
                    ReadUInt(ref power, "Введите мощность ядовитой слюны:");
                    character.Inventory.AddArtifact(new PoisounousSaliva(power));
                    break;
                case 6:
                    character.Inventory.AddArtifact(new BasiliskEye());
                    break;
            }            
        }
        static void AddSpell(CharacterMagician character)
        {
            uint n = 0;
            ReadUInt(ref n, "Введите номер заклинания, которое хотите выучить: \n 1 - \"Добавить здоровье\", \n 2 - \"Вылечить\",\n " +
                "3 - \"Противоядие\",\n 4 - \"Оживить\",\n 5 - \"Броня\",\n 6 - \"Отомри!\" ", 1, 6);
            switch (n)
            {
                case 1:
                    character.SpellsList.AddSpell(new AddHealth());
                    break;
                case 2:
                    character.SpellsList.AddSpell(new Heal());
                    break;
                case 3:
                    character.SpellsList.AddSpell(new Antidote());
                    break;
                case 4:
                    character.SpellsList.AddSpell(new DieOff());
                    break;
                case 5:
                    character.SpellsList.AddSpell(new Armor());
                    break;
                case 6:
                    character.SpellsList.AddSpell(new Revive());
                    break;
            }
        }
        static void RemoveSpell(CharacterMagician character)
        {
            uint n = 0;
            GetInventoryInfo(character);
            ReadUInt(ref n, "Введите номер заклинания, которое хотите забыть.", 1, (uint)character.SpellsList.Spells.Count);
            character.SpellsList.RemoveSpell((int)n);
        }
        static void RemoveArtifact(Character character)
        {
            uint n = 0;
            GetInventoryInfo(character);
            ReadUInt(ref n, "Введите номер арткфакта, который хотите выбросить.", 1, (uint)character.Inventory.Artifacts.Count);
            character.Inventory.RemoveArtifact((int)n);
        }

        static void GetCharacterInfo()
        {
            uint n = 0;
            ReadUInt(ref n, "Нажмите 1 - для главного нероя, 2 - для спутника, 3 - для врагов", 1, 3);
            switch (n)
            {
                case 1:
                    Console.WriteLine(mainCharacter.ToString());
                    break;
                case 2:
                    Console.WriteLine(satellite.ToString());
                    break;
                case 3:
                    foreach (var enemy in enemies)
                    {
                        Console.WriteLine(enemy.ToString());
                    }
                    break;
            }
               
                        
        }
        static void PrintShortInfo(Character character)
        {
            Console.WriteLine(character.Name + " :\t" + character.Hp.ToString() + "/" + character.MaxHp.ToString() +
                        "\tСостояние:" + character.Condition.ToString() + (typeof(CharacterMagician) == character.GetType() ? "Маг" : ""));
        }
        static void GetShortInfo()
        {
            uint n = 0;
            ReadUInt(ref n, "Нажмите 1 - для главного нероя, 2 - для спутника, 3 - для врагов", 1, 3);
            switch (n)
            {
                case 1:
                    PrintShortInfo(mainCharacter);
                    break;
                case 2:
                    PrintShortInfo(satellite);
                    break;
                case 3:
                    foreach (var enemy in enemies)
                    {
                        PrintShortInfo(enemy);
                    }
                    break;
            }
        }
        static void GetInventoryInfo(Character character)
        {
            if (character.Inventory.Artifacts.Count == 0)
            {
                Console.WriteLine("У вас пока нет артефактов!");
                return;
            }
            Console.WriteLine("Список ваших артефактов: ");
            int i = 0;
            foreach(var item in character.Inventory.Artifacts){
                Console.WriteLine(i++.ToString() + " :\t" + item.GetType().ToString() + "\tМощность: " + (item.HasPower ? item.Power.ToString():""));
            }
        }
        static void GetSpellsInfo(CharacterMagician character)
        {
            int i = 0;
            foreach (var item in character.SpellsList.Spells)
            {
                Console.WriteLine(i++.ToString() + " :\t" + item.GetType().ToString() + "\tCтоимость: " + item.Cost.ToString() 
                    + (item.HasPower ? "\t+ Можно задать мощность." : "") + (item.IsMotor ? "\t+ Надо подвигаться." : "") + (item.IsVerbal ? "\t+ Надо произвести." : ""));
            }
        }

        static bool isSateliteActive = false;
        static void ShowDialog() {
            uint n = 0;
            Spells.AddHealth addHealth = new Spells.AddHealth();
            Console.WriteLine("============================================================================================================");
            Console.WriteLine("Игра начата. Вы можете произвести следующие действия:");
            PrintActions();
            bool isGameStarted = true;
            while (isGameStarted) {
                ReadUInt(ref n, "Введите код действия (от 0 до 13, 0 - для справки): ", 0, 13);
                switch (n)
                {
                    case 0:
                        PrintActions();
                        break;
                    case 1:
                        isSateliteActive = true;
                        break;
                    case 2:
                        if (isSateliteActive)
                        {
                            TransferArtifact(satellite, mainCharacter);
                        }
                        else
                        {
                            TransferArtifact(mainCharacter, satellite);
                        }
                        break;
                    case 3:
                        if (isSateliteActive)
                        {
                            CastArtifact(satellite);
                        }
                        else
                        {
                            CastArtifact(mainCharacter);
                        }
                        break;
                    case 4:
                        if (isSateliteActive)
                        {
                            CastSpell(satellite);
                        }
                        else
                        {
                            CastSpell(mainCharacter);
                        }
                        break;
                    case 5:
                        if (isSateliteActive)
                        {
                            AddArtifact(satellite);
                        }
                        else
                        {
                            AddArtifact(mainCharacter);
                        }
                        break;
                    case 6:
                        if (isSateliteActive)
                        {
                            RemoveArtifact(satellite);
                        }
                        else
                        {
                            RemoveArtifact(mainCharacter);
                        }
                        break;
                    case 7:
                        if (isSateliteActive)
                        {
                           AddSpell(satellite);
                        }
                        else
                        {
                            AddSpell(mainCharacter);
                        }
                        break;
                    case 8:
                        if (isSateliteActive)
                        {
                            RemoveSpell(satellite);
                        }
                        else
                        {
                            RemoveSpell(mainCharacter);
                        }
                        break;
                    case 9:
                        GetCharacterInfo();
                        break;
                    case 10:
                        GetShortInfo();
                        break;
                    case 11:
                        GetInventoryInfo(isSateliteActive? satellite : mainCharacter);
                        break;
                    case 12:
                        GetSpellsInfo(isSateliteActive ? satellite : mainCharacter);
                        break;
                    case 13:
                        isGameStarted = false;
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует, попробуйте ещё раз");
                        break;
                }
            }

        }
        static CharacterMagician mainCharacter = ReadInfoAboutMagicianFromConsole();
        static CharacterMagician satellite = ReadInfoAboutMagicianFromConsole();
        static Character[] enemies = new Character[5];

        static void Main(string[] args) {            
            enemies[0] = new Character("Лёша", Character.RaceType.human, Character.GenderType.male, 20, 100, 100);
            enemies[1] = new Character("Миша", Character.RaceType.orc, Character.GenderType.male, 50, 200, 100);
            enemies[2] = new Character("Надя", Character.RaceType.gnome, Character.GenderType.female, 18, 300, 100);
            enemies[3] = new Character("Аня", Character.RaceType.goblin, Character.GenderType.female, 120, 400, 100);
            enemies[4] = new Character("Дима", Character.RaceType.elf, Character.GenderType.male, 20, 500, 100);
            ShowDialog();
        }
    }
}
