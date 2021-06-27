using System;

namespace MonteCarloPi
{
    class Program
    {
        static void Main(string[] args)
        {
            var mcObject = new MonteCarlo(30);
            var approxPi = mcObject.calcPi(100000);

            Console.WriteLine(approxPi);
        }
    }
}
