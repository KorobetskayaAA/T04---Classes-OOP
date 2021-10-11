using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    class Cat : Pet
    {
        public Cat(string name) : base(name) { }

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

        public override void UpdateState()
        {
            base.UpdateState();
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
