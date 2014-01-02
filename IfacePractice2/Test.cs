using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfacePractice2
{
    class Test : Bug, Car
    {
        public void Honk()
        {
            Console.WriteLine("Honk Honk");
        }

        public void Buzz()
        {
            Console.WriteLine("Buzz, Buzz");
        }
    }
}
