using DesignPatternsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public class Files : Item
    {
        public string Name;
        public Files(string Name)
        {
            this.Name = Name;
        }

        public override void EditItem()
        {
            throw new NotImplementedException();
        }
    }
}
