namespace DesignPatternsProject
{
    public class Draft : IState
    {
        public override void ChangeState(IState state)
        {
            this.state = state;
        }

        public override void ToCommit()
        {
            branch.BranchToCommit();
        }

        public override void ToMerge()
        {
            Console.WriteLine("Must commit");
        }

        public override void ToPush()
        {
            Console.WriteLine("Must commited");
        }
    }
}
