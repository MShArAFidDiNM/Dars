using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter number : ");
            
            Number = int.Parse(Console.ReadLine());
            Number *= 2;
            int[] array = new int[Number];            
            
            for (int i = 1; i < array.Length; i+=2)
            {
                Console.Write($"{ i}, ");
            }
            
            Main(args);
        }
    }
}
