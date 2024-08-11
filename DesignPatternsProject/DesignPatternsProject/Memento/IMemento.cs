using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public interface IMemento
    {
        string GetName();
        IState GetState();
        DateTime GetDate();
    }
}
