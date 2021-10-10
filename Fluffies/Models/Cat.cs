using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    class Cat
    {
        string name;
        int age = 0;
        double hunger = 5;
        double tiredness = 5;
        double happiness = 5;

        public Cat(string name)
        {
            this.name = name;
        }

        public bool IsTired()
        {
            return tiredness > 5;
        }

        public bool IsVeryTired()
        {
            return tiredness > 9;
        }

        public bool IsHungry()
        {
            return hunger > 6;
        }

        public bool IsVeryHungry()
        {
            return hunger > 8;
        }

        public bool IsFull()
        {
            return hunger < 2;
        }

        public bool IsAngry()
        {
            return happiness < 3;
        }

        public bool IsHappy()
        {
            return happiness > 8;
        }

        public void DoNothing()
        {
            if (IsTired())
            {
                Sleep();
            }
            else
            {
                hunger += 1;
                happiness -= 1;
                UpdateState();
            }
        }

        public void Sleep()
        {
            hunger += 4;
            tiredness = 0;
            UpdateState();
        }

        public void Eat()
        {
            if (IsVeryTired())
            {
                Sleep();
            }
            else if (!IsFull())
            {
                hunger = 0;
                tiredness += 1;
                happiness += 1;
                UpdateState();
            }
            else { 
                DoNothing(); 
            }
        }

        public void Play()
        {
            if (IsVeryTired())
            {
                Sleep();
            }
            else if (!IsHungry() && !IsTired())
            {
                hunger += 2;
                tiredness += 3;
                happiness += 3;
                UpdateState();
            }
            else
            {
                DoNothing();
            }
        }

        public void DoPet()
        {
            if (IsVeryTired())
            {
                Sleep();
            }
            else if (!IsAngry())
            {
                hunger += 1;
                tiredness += 1;
                happiness += 1;
                UpdateState();
            }
            else
            {
                DoNothing();
            }
        }

        public void UpdateState()
        {
            age++;
            if (IsFull())
            {
                happiness += 1;
            }
            else if (IsHungry())
            {
                happiness -= 1;
            }
            else if (IsVeryHungry())
            {
                happiness -= 2;
            }
            if (IsTired())
            {
                happiness -= 1;
            }
            else if (IsVeryTired())
            {
                happiness -= 2;
            }
        }
    }
}
