using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; private set; } = 0;
        double hunger = 5;
        public double Hunger 
        { 
            get { return hunger; } 
            set {
                if (value < 0)
                    hunger = 0;
                else if (value > 10)
                    hunger = 10;
                else hunger = value;
            } 
        }
        double tiredness = 5;
        public double Tiredness
        {
            get { return tiredness; }
            set
            {
                if (value < 0)
                    tiredness = 0;
                else if (value > 10)
                    tiredness = 10;
                else tiredness = value;
            }
        }
        double happiness = 5;
        public double Happiness
        {
            get { return happiness; }
            set
            {
                if (value < 0)
                    happiness = 0;
                else if (value > 10)
                    happiness = 10;
                else happiness = value;
            }
        }

        public Cat(string name)
        {
            Name = name;
        }

        public bool IsTired => Tiredness > 5;
        public bool IsVeryTired => Tiredness > 9;
        public bool IsHungry => Hunger > 6;
        public bool IsVeryHungry => Hunger > 8;
        public bool IsFull => Hunger < 2;
        public bool IsAngry => Happiness < 3;
        public bool IsHappy => Happiness > 8;

        public void DoNothing()
        {
            if (IsTired)
            {
                Sleep();
            }
            else
            {
                Hunger += 1;
                Happiness -= 1;
                UpdateState();
            }
        }

        public void Sleep()
        {
            Hunger += 4;
            Tiredness = 0;
            UpdateState();
        }

        public void Eat()
        {
            if (IsVeryTired)
            {
                Sleep();
            }
            else if (!IsFull)
            {
                Hunger = 0;
                Tiredness += 1;
                Happiness += 1;
                UpdateState();
            }
            else
            {
                DoNothing();
            }
        }

        public void Play()
        {
            if (IsVeryTired)
            {
                Sleep();
            }
            else if (!IsHungry && !IsTired)
            {
                Hunger += 2;
                Tiredness += 3;
                Happiness += 3;
                UpdateState();
            }
            else
            {
                DoNothing();
            }
        }

        public void DoPet()
        {
            if (IsVeryTired)
            {
                Sleep();
            }
            else if (!IsAngry)
            {
                Hunger += 1;
                Tiredness += 1;
                Happiness += 1;
                UpdateState();
            }
            else
            {
                DoNothing();
            }
        }

        public void UpdateState()
        {
            Age++;
            if (IsFull)
            {
                Happiness += 1;
            }
            else if (IsHungry)
            {
                Happiness -= 1;
            }
            else if (IsVeryHungry)
            {
                Happiness -= 2;
            }
            if (IsTired)
            {
                Happiness -= 1;
            }
            else if (IsVeryTired)
            {
                Happiness -= 2;
            }
        }
    }
}
