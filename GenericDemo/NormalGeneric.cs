using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class NormalGeneric
    {
        public static void IntNum(int[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
        public static void IntNum(double[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
        public static void IntNum(char[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}