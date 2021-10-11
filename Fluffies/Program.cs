using System;

namespace Fluffies
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Pet myPet;
            if (rnd.NextDouble() >= 0.5)
            { 
                myPet = new Cat("Мурка"); 
            }
            else
            {
                myPet = new Rabbit("Пушок");
            }
            myPet.DoNothing();
            myPet.Eat();
            if (myPet is Cat)
            {
                (myPet as Cat).Play();
            }
            myPet.DoPet();
            PrintCat(myPet);
        }

        private static void PrintCat(Pet myPet)
        {
            Console.WriteLine("{0}: возраст {1,2}, голод {2,2}, усталость {3,2}, счастье {4,2}",
                myPet.Name, myPet.Age, myPet.Hunger, myPet.Tiredness, myPet.Happiness);
        }
    }
}
