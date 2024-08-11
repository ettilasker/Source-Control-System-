using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public interface IEventListener
    {
        public void Update(IStatus status);
    }
}
