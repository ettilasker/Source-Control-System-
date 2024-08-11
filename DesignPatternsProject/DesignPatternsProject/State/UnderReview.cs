using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public class UnderReview : IState
    {
        public override void ChangeState(IState state)
        {
            this.state = state;
        }
        public override void ToCommit()
        {
            Console.WriteLine("Already commited");
        }

        public override void ToMerge()
        {
            Console.WriteLine("Under review");
        }

        public override void ToPush()
        {
            Console.WriteLine("Under review");
        }

    }
}
