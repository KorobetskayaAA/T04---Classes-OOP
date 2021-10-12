using System;
using System.Collections.Generic;
using System.Text;

namespace Fluffies
{
    class Rabbit : Pet
    {
        public Rabbit(string name) : base(name) { }

        const string EarsLeft = @" /)__/)";
        const string EarsRight = @"(\__(\";
        const string NeutralFace = @"
(=0.0=)
(______)*
";
        const string SleepingFace = @"
(=-.-=)
(______)*
";
        readonly Random random = new Random();

        public override string Face
        {
            get
            {
                string ears = random.NextDouble() >= 0.5 ? EarsLeft : EarsRight;
                string face = IsSleeping ? SleepingFace : NeutralFace;
                return ears + face;
            }
        }

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

        protected override void UpdateState()
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
