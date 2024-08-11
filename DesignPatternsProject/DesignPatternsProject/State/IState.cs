namespace DesignPatternsProject
{
    public abstract class IState
    {
        protected Branch branch;
        protected IState state;


        public abstract void ToMerge();
        public abstract void ToCommit();
        public abstract void ToPush();
        public abstract void ChangeState(IState state);
       

    }
}
