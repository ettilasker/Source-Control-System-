using DesignPatternsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public class Folder : Item
    {
        public string Name;
        public Folder(string Name)
        {
            this.Name = Name;
        }
        public override void EditItem()
        {
            throw new NotImplementedException();
        }
    }
}
