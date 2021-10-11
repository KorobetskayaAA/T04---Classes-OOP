using System;

namespace Fluffies
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Мурка");
            myCat.Eat();
            myCat.Play();
            myCat.DoPet();
            PrintCat(myCat);
        }

        private static void PrintCat(Cat myCat)
        {
            Console.WriteLine("{0}: возраст {1,2}, голод {2,2}, усталость {3,2}, счастье {4,2}",
                myCat.Name, myCat.Age, myCat.Hunger, myCat.Tiredness, myCat.Happiness);
        }
    }
}
