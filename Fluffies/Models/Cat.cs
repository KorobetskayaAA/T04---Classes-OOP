﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    class Cat : Pet
    {
        public Cat(string name) : base(name) { }


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

        protected override void Sleep()
        {
            Hunger += 4;
            base.Sleep();
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
