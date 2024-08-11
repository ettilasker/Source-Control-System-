using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public interface IStatus
    {
        public void Attach(IEventListener eventListener);
        public void Detach(IEventListener eventListener);
        public void Notify();

    }
}
