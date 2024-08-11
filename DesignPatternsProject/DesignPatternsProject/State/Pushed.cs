using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public class Pushed : IState
    {
        public override void ChangeState(IState state)
        {
            this.state = state;
        }
        public override void ToCommit()
        {
            Console.WriteLine("Nothing to commited");
        }

        public override void ToMerge()
        {
            Console.WriteLine("Already pushed");
        }

        public override void ToPush()
        {
            Console.WriteLine("Already commited");
        }


    }
}
