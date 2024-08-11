namespace DesignPatternsProject
{
    public class Merged : IState
    {
        public Files File { get ; set ; }
        public string Name { get ; set; }
        public string Status { get ; set ; }

        public override void ChangeState(IState state)
        {
            this.state = state;
        }
        public override void ToCommit()
        {
            throw new NotImplementedException("Already commited");
        }

        public override void ToMerge()
        {
            throw new NotImplementedException("Already merged");
        }

        public override void ToPush()
        {
            branch.BranchToPush();
        }
    }
}
