using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");        

            int[][] jagged = new int[5][];

            // Create a new array in the jagged array, and assign it.
            jagged[0] = new int[5];
            jagged[1] = new int[5];
            jagged[2] = new int[5];
            jagged[3] = new int[5];
            jagged[4] = new int[5];

            // Print out all elements in the jagged array.
            for (int i = 0; i < jagged.Length; i++)
            {
                int[] innerArray = jagged[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

    }
}
