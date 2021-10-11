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
            PrintCat(myPet);
            myPet.Eat();
            if (myPet is Cat)
            {
                (myPet as Cat).Play();
            }
            PrintCat(myPet);
            myPet.DoPet();
            PrintCat(myPet);
            myPet.DoNothing();
            PrintCat(myPet);
            myPet.DoPet();
            PrintCat(myPet);
            myPet.DoNothing();
            PrintCat(myPet);
        }

        private static void PrintCat(Pet myPet)
        {
            Console.WriteLine("{0}: возраст {1,2}, голод {2,2}, усталость {3,2}, счастье {4,2}\n{5}",
                myPet.Name, myPet.Age, myPet.Hunger, myPet.Tiredness, myPet.Happiness, myPet.Face);
        }
    }
}
