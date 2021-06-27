using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloPi
{
    // This class creates an object comprised of a square of a specifide side length and a quarter of a circle whose radius is the side length of the square.
    // The ability to set the side length is included for flexibility but is actually redundant since the method calcuations use ratios so a side length of 1 should work fine.

    public class MonteCarlo
    {
        int size;
        Random rand = new Random();

        public MonteCarlo(int sizeInput)
        {
            size = sizeInput;
        }

        public double calcPi(int dropNum)
        {
            // This method calculates an approximation of pi but comparing the number of random drops that fall with within the quarter circle the number that fall in the square.

            double sqrDrops = 0;
            double circDrops = 0;

            for (int i = 0; i < dropNum; i++) // Each iteration of generates a new random drop within the square. Increasing the number of drops increases the accuracy and precision of the algorithm.
            {
                double x = size * rand.NextDouble();
                double y = size * rand.NextDouble();

                sqrDrops += 1;
                if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= size) // Check if the drop falls within the quarter circle.
                {
                    circDrops += 1;
                }
            }

            double pi = 4 * (circDrops / sqrDrops);
            return pi;
        }
    }
}
