using System;
using static System.Console;


namespace Pointersv1
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int x = 100;
                int* xptr = &x;
                WriteLine((int)xptr);           //displays pointer value
                WriteLine(*xptr);               //displays pointed value
            }
            ReadKey();
        }
    }
}
