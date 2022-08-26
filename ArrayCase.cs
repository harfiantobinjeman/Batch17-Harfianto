using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class ArrayCase
    {
        //declare array whig int data type
        public static void TipyArray()
        {
            int[] arrint = new int[5];
            arrint[0] = 12;
            arrint[1] = 13;
            arrint[2] = 14;
            //arrint[6] = 15;

            string[] listGril = new string[] {"yuli","Rini","Widi"};
            foreach (var item in listGril)
            {
                Console.Write($"{item}");
            }

            for (int i = 0; i < listGril.Length; i++)
            {
                Console.Write($"{listGril[i]}");
            }
        }
        //method reteun or function input array int, return array int
        public static int[] InitArrayInt(int[] arr)
        {
            int[] arrint = arr;
            return arrint;
        }

        //initial value with random

        public static int[] InitArrayRandom(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
            }
            return arr;
        }
        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        //sum call element

        public static double SumElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int FindLargeElement(int[] arr)
        {
            int count = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > count)
                {
                    count = arr[i];
                }
            }
            return count;
        }

    }
}
