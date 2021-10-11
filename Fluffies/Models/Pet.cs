using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    class Pet
    {
        public Pet(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Age { get; private set; } = 0;
        double hunger = 5;
        public double Hunger
        {
            get { return hunger; }
            set
            {
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

        public bool IsTired => Tiredness > 5;
        public bool IsVeryTired => Tiredness > 9;
        public bool IsHungry => Hunger > 6;
        public bool IsVeryHungry => Hunger > 8;
        public bool IsFull => Hunger < 2;
        public bool IsAngry => Happiness < 3;
        public bool IsHappy => Happiness > 8;

        public virtual void UpdateState()
        {
            Age++;
        }
    }
}
