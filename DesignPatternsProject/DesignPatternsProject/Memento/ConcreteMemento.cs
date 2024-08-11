using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public class ConcreteMemento : IMemento
    {
        private IState state;
        private DateTime date;
        public ConcreteMemento(IState state) 
        { 
            this.state = state; 
            this.date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public string GetName()
        {
            return $"{this.date} / ({this.state.ToString()})";
           
        }

        public IState GetState()
        {
            return this.state;
        }
    }
}
