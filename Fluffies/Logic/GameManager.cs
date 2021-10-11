using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    enum PetTypes
    {
        Cat,
        Rabbit,
        Max
    }

    static class GameManager
    {
        public static void Start()
        {
            Pet pet = CreatePet(ChooseType(), InputName());
            while (Step(pet));
        }

        public static bool Step(Pet pet)
        {
            Console.Clear();
            PrintPet(pet);
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("F1 - Ничего не делать " +
                "F2 - Покормить " + 
                "F3 - Приласкать " +
                (pet is Cat ? "F4 - Играть " : "") +
                "Esc - Выйти ");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.F1: pet.DoNothing(); break;
                case ConsoleKey.F2: pet.Eat(); break;
                case ConsoleKey.F3: pet.DoPet(); break;
                case ConsoleKey.F4: if (pet is Cat) { (pet as Cat).Play(); } break;
                case ConsoleKey.Escape: return false;
            }
            return true;
        }

        private static void PrintPet(Pet myPet)
        {
            Console.WriteLine("{0}: возраст {1,2}, голод {2,2}, усталость {3,2}, счастье {4,2}\n{5}",
                myPet.Name, myPet.Age, myPet.Hunger, myPet.Tiredness, myPet.Happiness, myPet.Face);
        }

        private static PetTypes ChooseType()
        {
            var choosenType = PetTypes.Cat;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите тип питомца стрелками и нажмите Enter для завершения");
                Console.WriteLine("Кошка {0}", choosenType == PetTypes.Cat ? "(выбрано)" : "");
                Console.WriteLine("Кролик {0}", choosenType == PetTypes.Rabbit ? "(выбрано)" : "");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow: choosenType--; break;
                    case ConsoleKey.DownArrow: choosenType++; break;
                    case ConsoleKey.Enter: return choosenType;
                }
                choosenType = (PetTypes)(((int)choosenType + (int)PetTypes.Max) % (int)PetTypes.Max);
            }
        }

        private static string InputName()
        {
            Console.Clear();
            Console.Write("Введите имя питомца: ");
            return Console.ReadLine();
        }


        private static Pet CreatePet(PetTypes type, string name)
        {
            switch (type)
            {
                case PetTypes.Cat: return new Cat(name);
                case PetTypes.Rabbit: return new Rabbit(name);
            }
            return null;
        }
    }
}
