using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public class Committed : IState
    {
        private Item item;

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
            branch.BranchToMerge();
        }

        public override void ToPush()
        {
            branch.BranchToPush();
        }

 
    }
}
