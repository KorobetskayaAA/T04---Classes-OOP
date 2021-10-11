using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    class Rabbit : Pet
    {
        public Rabbit(string name) : base(name) { }

        public override void DoNothing()
        {
            if (IsVeryTired)
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

        protected override void Sleep()
        {
            Hunger += 3;
            base.Sleep();
        }

        public override void UpdateState()
        {
            base.UpdateState();
            if (IsFull)
            {
                Happiness += 2;
            }
            else if (IsHungry)
            {
                Happiness -= 1;
            }
            else if (IsVeryHungry)
            {
                Happiness -= 2;
            }
            if (IsVeryTired)
            {
                Happiness -= 1;
            }
        }
    }
}
