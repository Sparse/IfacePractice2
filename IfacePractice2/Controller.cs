using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfacePractice2
{
    class Controller
    {
        public void TestIt(Bug pBug, Car pCar)
        {
            if (pBug == null || pCar == null)

                if (pBug is Bug)
                {
                    Console.WriteLine("Its a bug!");
                    pBug.Buzz();
                }
                else
                    if (pCar is Car)
                    {
                        Console.WriteLine("Its a car!");
                        pCar.Honk();
                    }
                    else
                    {
                        Console.WriteLine("It's not a car or bug! WTF is this?!??");
                    }
        }
    }
}
