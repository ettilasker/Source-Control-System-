using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{

    public class Caretaker
    {
        private List<IMemento>? mementoList = new List<IMemento>();
        private Branch branch;
        public Caretaker(Branch branch)
        {
            this.branch = branch;
        }
        public void Backup()
        {
            Console.WriteLine("Saving branch state...");
            this.mementoList.Add(branch.SaveBranchState());
        }

        public void Undo() 
        {
            if(this.mementoList.Count == 0)
            {
                return;
            }
            var mementoToDelete = this.mementoList.Last();
            this.mementoList.Remove(mementoToDelete);
            Console.WriteLine("undid the last change");
            try
            {
                this.branch.Restore(mementoToDelete);
            }
            catch(Exception)
            {
                this.Undo();
            }
        }
         public void ShowHistory()
         {
            Console.WriteLine("History list:");
            if(mementoList.Count == 0)
            {
                Console.WriteLine("No history");
            }
            else
            {
               foreach(IMemento m in mementoList)
                {
                    Console.WriteLine(m.GetName());
                }
            }
            
         }
    }
}
