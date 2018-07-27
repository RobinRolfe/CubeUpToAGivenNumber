using System;

namespace CubeUpToAGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to cube");

            int[] numarray = new int[Convert.ToInt32(Console.ReadLine())];
            int value = 1;


            for (int i = 0; i < numarray.Length; i++)
            {
                numarray.SetValue(value, i);
                value++;
            }

            for (int i = 0; i < numarray.Length; i++)
            {

                Console.WriteLine("the number is " + numarray[i] + " and the cube of " + numarray[i] + " is " + numarray[i] * numarray[i] * numarray[i]);

            }

            Console.ReadLine();
        }
    }
}
