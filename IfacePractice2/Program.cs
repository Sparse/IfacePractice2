using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfacePractice2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Honk();
            test.Buzz();
            Controller controller = new Controller();
            controller.TestIt(test, null);
            controller.TestIt(null, test);
            controller.TestIt(null, null);
            Console.ReadLine();
        }
    }
}
