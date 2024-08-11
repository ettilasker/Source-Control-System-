namespace DesignPatternsProject
{
    public class Branch : IStatus 
    {
        public List<Item> items;
        public IState state;
        public string branchName;
        
        public Branch(string branchName)
        {
            items = new();
            state = new Draft();
            this.branchName = branchName;
        }
        public Branch CreateBranch(string newBranch)
        {
            return new Branch(newBranch);
        }
        #region State

        public void BranchToCommit()
        {
            Console.WriteLine("commited");
            this.state = new Committed();
            this.state = new UnderReview();
        }
        public void BranchToMerge()
        {
            Console.WriteLine("merged");
            this.state = new Merged();
        }
        public void BranchToPush()
        {
            Console.WriteLine("pushed");
            this.state = new Pushed();
        }
      


       
        #endregion

        #region Composite
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }
        #endregion

        #region Memento        
        public IMemento SaveBranchState()
        {
            return new ConcreteMemento(this.state);
        }
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Memento unknown");
            }
            this.state = memento.GetState();
            Console.WriteLine($"state has changed to: {state}");
        }
        #endregion

        #region Observer
        List<IEventListener> eventListeners = new List<IEventListener>();
        public void Attach(IEventListener eventListener)
        {
            Console.WriteLine("Attached an observer.");
            eventListeners.Add(eventListener);
        }
        public void Detach(IEventListener eventListener)
        {
            eventListeners.Remove(eventListener);
            Console.WriteLine("Detached an observer.");
        }
        public void Notify()
        {
            Console.WriteLine("Notifying observers...");
            foreach (var eventListener in eventListeners)
            {
                eventListener.Update(this);
            }
        }
        #endregion
    }


}
