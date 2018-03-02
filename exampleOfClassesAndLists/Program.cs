using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleOfClassesAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            exxxampl p1 = new exxxampl(7, 6 , '^');
            p1.DrawAgain();

            exxxampl p2 = new exxxampl(4, 6, '^');
            p2.DrawAgain();

            exxxampl p3 = new exxxampl(9, 6, ')');
            p3.DrawAgain();

            exxxampl p4 = new exxxampl(2, 6, '(');
            p4.DrawAgain();

            Console.ReadLine();

            List<exxxampl> exp = new List<exxxampl>();
            exp.Add(p1);
            exp.Add(p2);
            exp.Add(p3);
            exp.Add(p4);
        }
    }
}
