using DesignPatternsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public abstract void EditItem();
    }
}
