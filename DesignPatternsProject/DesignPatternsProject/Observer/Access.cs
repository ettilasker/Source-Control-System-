using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject
{
    public class Access : IEventListener
    {
        public void Update(IStatus status)
        {
            Console.WriteLine("To observe??? y/n");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.WriteLine("you are observing the branch");
            }
            else
            {
                Console.WriteLine("you have no access to the branch");
            }
        }
    }
}
