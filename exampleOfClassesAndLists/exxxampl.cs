using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleOfClassesAndLists
{
    class exxxampl
    {
        public int a;
        public int b;
        public char ab;

        public exxxampl(int _a, int _b, char _ab)
        {
            a = _a;
            b = _b;
            ab = _ab;
        }

        public void DrawAgain()
        {
            Console.SetCursorPosition(a,b);
            Console.Write(ab);
        }
    }
}
