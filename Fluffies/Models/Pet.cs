using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    abstract class Pet
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
        public bool IsSleeping { get; set; } = false;

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
            IsSleeping = false;
        }

        public virtual void DoNothing()
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

        protected virtual void Sleep()
        {
            Tiredness = 0;
            UpdateState();
            IsSleeping = true;
        }

        public virtual void Eat()
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

        public virtual void DoPet()
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

        public abstract string Face { get; }
    }
}
